﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaterialDialogsCore;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using WoWonder.Activities.Comment;
using WoWonder.Activities.NativePost.Post;
using WoWonder.Activities.Videos;
using WoWonder.Helpers.Controller;
using WoWonder.Helpers.Model;
using WoWonder.Helpers.Utils;
using WoWonderClient.Classes.Movies;
using WoWonderClient.Requests;
using Exception = System.Exception;

namespace WoWonder.Activities.Movies
{
    public class MoviesCommentClickListener : Java.Lang.Object, MaterialDialog.IListCallback, MaterialDialog.ISingleButtonCallback
    {
        private readonly Activity MainContext;
        private CommentsMoviesObject CommentObject;
        private string TypeDialog;
        private readonly string TypeClass;

        public MoviesCommentClickListener(Activity context, string typeClass)
        {
            MainContext = context;
            TypeClass = typeClass;
        }

        public void MoreCommentReplyPostClick(CommentReplyMoviesClickEventArgs e)
        {
            try
            {
                if (Methods.CheckConnectivity())
                {
                    TypeDialog = "MoreComment";
                    CommentObject = e.CommentObject;

                    var arrayAdapter = new List<string>();
                    var dialogList = new MaterialDialog.Builder(MainContext).Theme(WoWonderTools.IsTabDark() ? MaterialDialogsTheme.Dark : MaterialDialogsTheme.Light);

                    arrayAdapter.Add(MainContext.GetString(Resource.String.Lbl_CopeText));

                    if (CommentObject?.IsOwner != null && (bool)CommentObject?.IsOwner || CommentObject?.UserData?.UserId == UserDetails.UserId)
                        arrayAdapter.Add(MainContext.GetString(Resource.String.Lbl_Delete));

                    dialogList.Title(MainContext.GetString(Resource.String.Lbl_More)).TitleColorRes(Resource.Color.primary);
                    dialogList.Items(arrayAdapter);
                    dialogList.PositiveText(MainContext.GetText(Resource.String.Lbl_Close)).OnNegative(this);
                    dialogList.AlwaysCallSingleChoiceCallback();
                    dialogList.ItemsCallback(this).Build().Show();
                }
                else
                {
                    ToastUtils.ShowToast(MainContext, MainContext.GetText(Resource.String.Lbl_CheckYourInternetConnection), ToastLength.Short);
                }
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        //Event Menu >> Delete Comment
        private void DeleteCommentEvent(CommentsMoviesObject item)
        {
            try
            {
                if (!Methods.CheckConnectivity())
                {
                    ToastUtils.ShowToast(MainContext, MainContext.GetText(Resource.String.Lbl_CheckYourInternetConnection), ToastLength.Short);
                    return;
                }

                TypeDialog = "DeleteComment";
                CommentObject = item;

                var dialog = new MaterialDialog.Builder(MainContext).Theme(WoWonderTools.IsTabDark() ? MaterialDialogsTheme.Dark : MaterialDialogsTheme.Light);
                dialog.Title(MainContext.GetText(Resource.String.Lbl_DeleteComment)).TitleColorRes(Resource.Color.primary);
                dialog.Content(MainContext.GetText(Resource.String.Lbl_AreYouSureDeleteComment));
                dialog.PositiveText(MainContext.GetText(Resource.String.Lbl_Yes)).OnPositive(this);
                dialog.NegativeText(MainContext.GetText(Resource.String.Lbl_No)).OnNegative(this);
                dialog.AlwaysCallSingleChoiceCallback();
                dialog.ItemsCallback(this).Build().Show();
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        public void ProfileClick(CommentReplyMoviesClickEventArgs e)
        {
            try
            {
                WoWonderTools.OpenProfile(MainContext, e.CommentObject.UserData.UserId, e.CommentObject.UserData);
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        public void LikeCommentReplyPostClick(CommentReplyMoviesClickEventArgs e)
        {
            try
            {
                if (!Methods.CheckConnectivity())
                {
                    ToastUtils.ShowToast(MainContext, MainContext.GetText(Resource.String.Lbl_CheckYourInternetConnection), ToastLength.Short);
                    return;
                }

                switch (e.Holder.LikeTextView?.Tag?.ToString())
                {
                    case "Liked":
                        e.CommentObject.IsCommentLiked = false;

                        e.Holder.LikeTextView.Text = MainContext.GetText(Resource.String.Btn_Like);
                        //e.Holder.LikeTextView.SetTextColor(WoWonderTools.IsTabDark() ? Color.White : Color.Black);
                        e.Holder.LikeTextView.SetTextColor(WoWonderTools.IsTabDark() ? Color.White : Color.ParseColor("#888888"));
                        e.Holder.LikeTextView.Tag = "Like";
                        break;
                    default:
                        e.CommentObject.IsCommentLiked = true;

                        e.Holder.LikeTextView.Text = MainContext.GetText(Resource.String.Btn_Liked);
                        e.Holder.LikeTextView.SetTextColor(Color.ParseColor(AppSettings.MainColor));
                        e.Holder.LikeTextView.Tag = "Liked";
                        break;
                }

                //sent api like comment 
                switch (TypeClass)
                {
                    case "Comment":
                        PollyController.RunRetryPolicyFunction(new List<Func<Task>> { () => RequestsAsync.Movies.LikeUnLikeCommentAsync(e.CommentObject.MovieId, e.CommentObject.Id) });
                        break;
                    case "Reply":
                        PollyController.RunRetryPolicyFunction(new List<Func<Task>> { () => RequestsAsync.Movies.LikeUnLikeCommentAsync(e.CommentObject.MovieId, e.CommentObject.Id, "reply_like") });
                        break;
                }
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        public void DislikeCommentReplyPostClick(CommentReplyMoviesClickEventArgs e)
        {
            try
            {
                if (!Methods.CheckConnectivity())
                {
                    ToastUtils.ShowToast(MainContext, MainContext.GetText(Resource.String.Lbl_CheckYourInternetConnection), ToastLength.Short);
                    return;
                }

                switch (e.Holder.LikeTextView?.Tag?.ToString())
                {
                    case "Liked":
                        e.CommentObject.IsCommentLiked = false;

                        e.Holder.LikeTextView.Text = MainContext.GetText(Resource.String.Btn_Like);
                        //e.Holder.LikeTextView.SetTextColor(WoWonderTools.IsTabDark() ? Color.White : Color.Black);
                        e.Holder.LikeTextView.SetTextColor(WoWonderTools.IsTabDark() ? Color.White : Color.ParseColor("#888888"));
                        e.Holder.LikeTextView.Tag = "Like";
                        break;
                    default:
                        e.CommentObject.IsCommentLiked = true;

                        e.Holder.LikeTextView.Text = MainContext.GetText(Resource.String.Btn_Liked);
                        e.Holder.LikeTextView.SetTextColor(Color.ParseColor(AppSettings.MainColor));
                        e.Holder.LikeTextView.Tag = "Liked";

                        //sent api dislike comment 
                        switch (TypeClass)
                        {
                            case "Comment":
                                PollyController.RunRetryPolicyFunction(new List<Func<Task>> { () => RequestsAsync.Movies.DisLikeUnDisLikeCommentAsync(e.CommentObject.MovieId, e.CommentObject.Id) });
                                break;
                            case "Reply":
                                PollyController.RunRetryPolicyFunction(new List<Func<Task>> { () => RequestsAsync.Movies.DisLikeUnDisLikeCommentAsync(e.CommentObject.MovieId, e.CommentObject.Id, "reply_dislike") });
                                break;
                        }

                        break;
                }
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        //Event Menu >> Reply
        public void CommentReplyClick(CommentReplyMoviesClickEventArgs e)
        {
            try
            {
                // show dialog :
                var intent = new Intent(MainContext, typeof(ReplyCommentBottomSheet));
                intent.PutExtra("Type", "Movies");
                intent.PutExtra("Id", e.CommentObject.Id);
                intent.PutExtra("Object", JsonConvert.SerializeObject(e.CommentObject));
                MainContext.StartActivity(intent);
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }


        #region MaterialDialog

        public void OnSelection(MaterialDialog dialog, View itemView, int position, string itemString)
        {
            try
            {
                string text = itemString;
                if (text == MainContext.GetString(Resource.String.Lbl_CopeText))
                {
                    Methods.CopyToClipboard(MainContext, Methods.FunString.DecodeString(CommentObject.Text));
                }
                else if (text == MainContext.GetString(Resource.String.Lbl_Delete))
                {
                    DeleteCommentEvent(CommentObject);
                }
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        public void OnClick(MaterialDialog p0, DialogAction p1)
        {
            try
            {
                switch (TypeDialog)
                {
                    case "DeleteComment" when p1 == DialogAction.Positive:
                        MainContext?.RunOnUiThread(() =>
                        {
                            try
                            {
                                switch (TypeClass)
                                {
                                    case "Comment":
                                    {
                                        //TypeClass
                                        var adapterGlobal = VideoViewerActivity.GetInstance()?.MAdapter;
                                        var dataGlobal = adapterGlobal?.CommentList?.FirstOrDefault(a => a.Id == CommentObject?.Id);
                                        if (dataGlobal != null)
                                        {
                                            var index = adapterGlobal.CommentList.IndexOf(dataGlobal);
                                            switch (index)
                                            {
                                                case > -1:
                                                    adapterGlobal.CommentList.RemoveAt(index);
                                                    adapterGlobal.NotifyItemRemoved(index);
                                                    break;
                                            }
                                        }

                                        if (!Methods.CheckConnectivity())
                                            ToastUtils.ShowToast(MainContext, MainContext.GetString(Resource.String.Lbl_CheckYourInternetConnection), ToastLength.Short);
                                        else
                                            PollyController.RunRetryPolicyFunction(new List<Func<Task>> { () => RequestsAsync.Movies.DeleteCommentAsync(CommentObject.MovieId, CommentObject.Id) });
                                        break;
                                    }
                                    case "Reply":
                                    {
                                        //TypeClass
                                        var adapterGlobal = ReplyCommentBottomSheet.GetInstance()?.MAdapterMovies;
                                        var dataGlobal = adapterGlobal?.CommentList?.FirstOrDefault(a => a.Id == CommentObject?.Id);
                                        if (dataGlobal != null)
                                        {
                                            var index = adapterGlobal.CommentList.IndexOf(dataGlobal);
                                            switch (index)
                                            {
                                                case > -1:
                                                    adapterGlobal.CommentList.RemoveAt(index);
                                                    adapterGlobal.NotifyItemRemoved(index);
                                                    break;
                                            }
                                        }

                                        if (!Methods.CheckConnectivity())
                                            ToastUtils.ShowToast(MainContext, MainContext.GetString(Resource.String.Lbl_CheckYourInternetConnection), ToastLength.Short);
                                        else
                                            PollyController.RunRetryPolicyFunction(new List<Func<Task>> { () => RequestsAsync.Movies.DeleteCommentAsync(CommentObject.MovieId, CommentObject.Id, "reply_delete") });
                                        break;
                                    }
                                }

                                ToastUtils.ShowToast(MainContext, MainContext.GetText(Resource.String.Lbl_CommentSuccessfullyDeleted), ToastLength.Short);
                            }
                            catch (Exception e)
                            {
                                Methods.DisplayReportResultTrack(e);
                            }
                        });
                        break;
                    case "DeleteComment":
                    {
                        if (p1 == DialogAction.Negative)
                        {
                            p0.Dismiss();
                        }

                        break;
                    }
                    default:
                    {
                        if (p1 == DialogAction.Positive)
                        {

                        }
                        else if (p1 == DialogAction.Negative)
                        {
                            p0.Dismiss();
                        }

                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        #endregion

    }
}