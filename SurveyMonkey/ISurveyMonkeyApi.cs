﻿using System.Collections.Generic;
using System.Net;
using SurveyMonkey.Containers;
using SurveyMonkey.RequestSettings;

namespace SurveyMonkey
{
    public interface ISurveyMonkeyApi
    {
        SendSurveyResponse SendSurvey(long collectorId, long messageId, SendSurveySettings settings);

        List<Survey> GetSurveyList();

        List<Survey> GetSurveyList(GetSurveyListSettings settings);

        Survey GetSurveyOverview(long surveyId);

        Survey GetSurveyDetails(long surveyId);

        List<Response> GetSurveyResponseOverviewList(long surveyId);

        List<Response> GetSurveyResponseDetailsList(long surveyId);

        List<Response> GetSurveyResponseOverviewList(long surveyId, GetResponseListSettings settings);

        List<Response> GetSurveyResponseDetailsList(long surveyId, GetResponseListSettings settings);
        PaginatedResponse<Response> GetSurveyResponseBulkPaginated(long surveyId, GetResponseListSettings settings);
        Survey CreateSurvey(CreateSurveySettings settings);
        List<Response> GetCollectorResponseOverviewList(long collectorId);

        List<Response> GetCollectorResponseDetailsList(long collectorId);

        List<Response> GetCollectorResponseOverviewList(long collectorId, GetResponseListSettings settings);

        List<Response> GetCollectorResponseDetailsList(long collectorId, GetResponseListSettings settings);
        
        

        Response GetSurveyResponseOverview(long surveyId, long responseId);

        Response GetSurveyResponseDetails(long surveyId, long responseId);

        Response GetCollectorResponseOverview(long collectorId, long responseId);

        Response GetCollectorResponseDetails(long collectorId, long responseId);

        List<Survey> PopulateSurveyResponseInformationBulk(List<long> surveyIds);

        Survey PopulateSurveyResponseInformation(long surveyId);

        void MatchResponseToSurveyStructure(Survey survey, Response response);

        List<Collector> GetCollectorList(long surveyId);

        List<Collector> GetCollectorList(long surveyId, GetCollectorListSettings settings);

        Collector GetCollectorDetails(long collectorId);

        List<Message> GetMessageList(long collectorId);

        List<Message> GetMessageList(long collectorId, PagingSettings settings);

        Message GetMessageDetails(long collectorId, long messageId);

        List<Recipient> GetCollectorRecipientList(long collectorId);

        List<Recipient> GetCollectorRecipientList(long collectorId, GetRecipientListSettings settings);

        Message CreateMessage(long collectorId, CreateNewMessageSettings settings);

        BulkRecipientResponse AddRecipientsToMessage(long collectorId, long messageId, BulkRecipientSettings settings);

        List<Recipient> GetMessageRecipientList(long collectorId, long messageId);

        List<Recipient> GetMessageRecipientList(long collectorId, long messageId, GetRecipientListSettings settings);

        Recipient GetRecipientDetails(long collectorId, long recipientId);

        List<SurveyCategory> GetSurveyCategoryList();

        List<SurveyCategory> GetSurveyCategoryList(GetSurveyCategoryListSettings settings);

        List<SurveyTemplate> GetSurveyTemplateList();

        List<SurveyTemplate> GetSurveyTemplateList(GetSurveyTemplateListSettings settings);

        List<Page> GetPageList(long surveyId);

        List<Page> GetPageList(long surveyId, PagingSettings settings);

        Page GetPageDetails(long surveyId, long pageId);

        List<Question> GetQuestionList(long surveyId, long pageId);

        List<Question> GetQuestionList(long surveyId, long pageId, PagingSettings settings);

        Question GetQuestionDetails(long surveyId, long pageId, long questionId);

        User GetUserDetails();

        List<Group> GetGroupList();

        List<Group> GetGroupList(PagingSettings settings);

        Group GetGroupDetails(long groupId);

        List<Member> GetMemberList(long groupId);

        List<Member> GetMemberList(long groupId, PagingSettings settings);

        Member GetMemberDetails(long groupId, long memberId);

        Collector CreateCollector(long surveyId, CreateCollectorSettings settings);

        List<Webhook> GetWebhookList();

        List<Webhook> GetWebhookList(PagingSettings settings);

        Webhook GetWebhookDetails(long webhookId);

        Webhook CreateWebhook(Webhook webhook);

        Webhook ReplaceWebhook(long webhookId, Webhook webhook);

        Webhook ModifyWebhook(long webhookId, Webhook webhook);

        Webhook DeleteWebhook(long webhookId);

        ContactList GetContactList(long contactListId);

        List<ContactList> GetContactLists();

        List<ContactList> GetContactLists(PagingSettings settings);

        List<Contact> GetContactsFromList(long contactListId);

        List<Contact> GetContactsFromList(long contactListId, GetContactsSettings settings);

        List<Contact> GetContacts(GetContactsSettings settings);

        BulkContactListResponse CreateBulkContactsForList(long contactListId, CreateBulkContactListSettings settings);

        ContactList CreateContactList(CreateContactListSettings settings);

        ContactList DeleteContactList(long contactListId);

        int ApiRequestsMade { get; }
        ApiHeaders ApiHeaders { get; }

        void Dispose();

        WebHeaderCollection ResponseHeaders { get; }
    }
}