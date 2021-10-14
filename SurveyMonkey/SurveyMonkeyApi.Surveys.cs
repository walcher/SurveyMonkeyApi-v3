﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using SurveyMonkey.Containers;
using SurveyMonkey.RequestSettings;

namespace SurveyMonkey
{
    public partial class SurveyMonkeyApi
    {
        public List<Survey> GetSurveyList()
        {
            var settings = new GetSurveyListSettings();
            return GetSurveyListPager(settings);
        }

        public List<Survey> GetSurveyList(GetSurveyListSettings settings)
        {
            return GetSurveyListPager(settings);
        }

        private List<Survey> GetSurveyListPager(IPagingSettings settings)
        {
            string endPoint = "/surveys";
            const int maxResultsPerPage = 1000;
            var results = Page(settings, endPoint, typeof(List<Survey>), maxResultsPerPage);
            return results.ToList().ConvertAll(o => (Survey)o);
        }

        public Survey GetSurveyOverview(long surveyId)
        {
            var verb = Verb.GET;
            var endpoint = String.Format("/surveys/{0}", surveyId);
            JToken result = MakeApiRequest(endpoint, verb, new RequestData());
            var survey = result.ToObject<Survey>();
            return survey;
        }

        public Survey GetSurveyDetails(long surveyId)
        {
            string endPoint = String.Format("/surveys/{0}/details", surveyId);
            var verb = Verb.GET;
            JToken result = MakeApiRequest(endPoint, verb, new RequestData());
            var survey = result.ToObject<Survey>();
            return survey;
        }

        public List<SurveyCategory> GetSurveyCategoryList()
        {
            var settings = new GetSurveyCategoryListSettings();
            return GetSurveyCategoryListPager(settings);
        }

        public List<SurveyCategory> GetSurveyCategoryList(GetSurveyCategoryListSettings settings)
        {
            return GetSurveyCategoryListPager(settings);
        }

        private List<SurveyCategory> GetSurveyCategoryListPager(IPagingSettings settings)
        {
            string endPoint = "/survey_categories";
            const int maxResultsPerPage = 1000;
            var results = Page(settings, endPoint, typeof(List<SurveyCategory>), maxResultsPerPage);
            return results.ToList().ConvertAll(o => (SurveyCategory)o);
        }

        public List<SurveyTemplate> GetSurveyTemplateList()
        {
            var settings = new GetSurveyTemplateListSettings();
            return GetSurveyTemplateListPager(settings);
        }

        public List<SurveyTemplate> GetSurveyTemplateList(GetSurveyTemplateListSettings settings)
        {
            return GetSurveyTemplateListPager(settings);
        }

        private List<SurveyTemplate> GetSurveyTemplateListPager(IPagingSettings settings)
        {
            string endPoint = "/survey_templates";
            const int maxResultsPerPage = 1000;
            var results = Page(settings, endPoint, typeof(List<SurveyTemplate>), maxResultsPerPage);
            return results.ToList().ConvertAll(o => (SurveyTemplate)o);
        }

        public List<Page> GetPageList(long surveyId)
        {
            var settings = new PagingSettings();
            return GetPageListPager(surveyId, settings);
        }

        public List<Page> GetPageList(long surveyId, PagingSettings settings)
        {
            return GetPageListPager(surveyId, settings);
        }

        private List<Page> GetPageListPager(long surveyId, IPagingSettings settings)
        {
            string endPoint = String.Format("/surveys/{0}/pages", surveyId);
            const int maxResultsPerPage = 100;
            var results = Page(settings, endPoint, typeof(List<Page>), maxResultsPerPage);
            return results.ToList().ConvertAll(o => (Page)o);
        }

        public Page GetPageDetails(long surveyId, long pageId)
        {
            string endPoint = String.Format("/surveys/{0}/pages/{1}", surveyId, pageId);
            var verb = Verb.GET;
            JToken result = MakeApiRequest(endPoint, verb, new RequestData());
            var page = result.ToObject<Page>();
            return page;
        }

        public List<Question> GetQuestionList(long surveyId, long pageId)
        {
            var settings = new PagingSettings();
            return GetQuestionListPager(surveyId, pageId, settings);
        }

        public List<Question> GetQuestionList(long surveyId, long pageId, PagingSettings settings)
        {
            return GetQuestionListPager(surveyId, pageId, settings);
        }

        private List<Question> GetQuestionListPager(long surveyId, long pageId, IPagingSettings settings)
        {
            string endPoint = String.Format("/surveys/{0}/pages/{1}/questions", surveyId, pageId);
            const int maxResultsPerPage = 100;
            var results = Page(settings, endPoint, typeof(List<Question>), maxResultsPerPage);
            return results.ToList().ConvertAll(o => (Question)o);
        }

        public Question GetQuestionDetails(long surveyId, long pageId, long questionId)
        {
            string endPoint = String.Format("/surveys/{0}/pages/{1}/questions/{2}", surveyId, pageId, questionId);
            var verb = Verb.GET;
            JToken result = MakeApiRequest(endPoint, verb, new RequestData());
            var question = result.ToObject<Question>();
            return question;
        }

        public SendSurveyResponse SendSurvey(long collectorId, long messageId, SendSurveySettings settings)
        {
            string endPoint = String.Format("/collectors/{0}/messages/{1}/send", collectorId, messageId);
            var verb = Verb.POST;
            var requestData = Helpers.RequestSettingsHelper.GetPopulatedProperties(settings);
            JToken result = MakeApiRequest(endPoint, verb, requestData);
            var response = result.ToObject<SendSurveyResponse>();
            return response;
        }

        public Survey CreateSurvey(CreateSurveySettings settings)
        {
            string endPoint = "/surveys";
            var verb = Verb.POST;
            var requestData = Helpers.RequestSettingsHelper.GetPopulatedProperties(settings);
            JToken result = MakeApiRequest(endPoint, verb, requestData);
            var response = result.ToObject<Survey>();
            return response;
        }
    }
}