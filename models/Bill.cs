using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace PMGIndexer
{
    public class Response<T>  where T : class
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<T> Results { get; set; }
    }

    public class Bill
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public string Summary { get; set; }
        public DateTime Published { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string BillType { get; set; }
        public string BillNumber { get; set; }
        public int Parliament { get; set; }
        public int Session { get; set; }
        public int Provisional { get; set; }
        public string Link { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public string CreatedByEmail { get; set; }
        public int PublishedBy { get; set; }
        public string PublishedByName { get; set; }
        public string PublishedByEmail { get; set; }
        public int LastUpdatedBy { get; set; }
        public string LastUpdatedByName { get; set; }
        public string LastUpdatedByEmail { get; set; }
    }

    public class Briefing
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Summary { get; set; }
    public DateTime Published { get; set; }
    public DateTime LastUpdated { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public int CreatedBy { get; set; }
    public string CreatedByName { get; set; }
    public string CreatedByEmail { get; set; }
    public int PublishedBy { get; set; }
    public string PublishedByName { get; set; }
    public string PublishedByEmail { get; set; }
    public int LastUpdatedBy { get; set; }
    public string LastUpdatedByName { get; set; }
    public string LastUpdatedByEmail { get; set; }
}

public class Question
{
    public string created_at { get; set; }
    public string updated_at { get; set; }
    public int id { get; set; }
    public string question { get; set; }
    public int minister_id { get; set; }
    public string minister_name { get; set; }
    public string document_url { get; set; }
    public string document_type { get; set; }
    public string document_name { get; set; }
    public string document_extension { get; set; }
    public int document_size { get; set; }
    public string url { get; set; }
    public string when { get; set; }
    public string house_name { get; set; }
    public string house_name_short { get; set; }
}

public class TabledCommitteeReport
{
    public string created_at { get; set; }
    public string updated_at { get; set; }
    public int id { get; set; }
    public string title { get; set; }
    public int committee_id { get; set; }
    public string committee_name { get; set; }
    public string document_url { get; set; }
    public string document_type { get; set; }
    public string document_name { get; set; }
    public string document_extension { get; set; }
    public int document_size { get; set; }
    public string url { get; set; }
    public string when { get; set; }
}


public class CallForComment
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ShortTitle { get; set; }
    public string Summary { get; set; }
    public DateTime Published { get; set; }
    public DateTime LastUpdated { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public int CreatedBy { get; set; }
    public string CreatedByName { get; set; }
    public string CreatedByEmail { get; set; }
    public int PublishedBy { get; set; }
    public string PublishedByName { get; set; }
    public string PublishedByEmail { get; set; }
    public int LastUpdatedBy { get; set; }
    public string LastUpdatedByName { get; set; }
    public string LastUpdatedByEmail { get; set; }
    public int Department { get; set; }
    public string DepartmentName { get; set; }
    public string DepartmentContactPerson { get; set; }
    public string DepartmentContactEmail { get; set; }
    public string DepartmentContactPhone { get; set; }
    public string DepartmentWebpage { get; set; }
    public string DepartmentContactAddress { get; set; }
    public DateTime SubmissionDeadline { get; set; }
    public DateTime MeetingDate { get; set; }
    public string MeetingVenue { get; set; }
    public string MeetingTime { get; set; }
    public string Tag { get; set; }
}
public class Minister
{
    public string created_at { get; set; }
    public string updated_at { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public string url { get; set; }
    public Committee committee { get; set; }
    public string questions_url { get; set; }
}


public class QuestionReply
{
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public int id { get; set; }
    public int question_id { get; set; }
    public int member_id { get; set; }
    public int minister_id { get; set; }
    public int house_id { get; set; }
    public string text { get; set; }
    public bool answer { get; set; }
    public string url { get; set; }
    public Question question { get; set; }
    public Member member { get; set; }
    public Minister minister { get; set; }
    public House house { get; set; }
}

public class CommitteeMeetingAttendance
{
    public string created_at { get; set; }
    public string updated_at { get; set; }
    public int id { get; set; }
    public int meeting_id { get; set; }
    public int member_id { get; set; }
    public bool present { get; set; }
    public bool proxy { get; set; }
    public string url { get; set; }
    public Member member { get; set; }
}

public class Member
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ProfilePicUrl { get; set; }
    public string Bio { get; set; }
    public int HouseId { get; set; }
    public int PartyId { get; set; }
    public int? ProvinceId { get; set; }
    public DateTime StartDate { get; set; }
    public string PaLink { get; set; }
    public bool Current { get; set; }
    public string Url { get; set; }
    public House House { get; set; }
    public Party Party { get; set; }
    public List<Membership> Memberships { get; set; }
}

public class House
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string NameShort { get; set; }
    public string Sphere { get; set; }
    public object ContactDetails { get; set; }
    public int? SpeakerId { get; set; }
}

public class Party
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Membership
{
    public int Id { get; set; }
    public int? TypeId { get; set; }
    public int CommitteeId { get; set; }
    public int MemberId { get; set; }
    public Committee Committee { get; set; }
}

public class Post
{
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public int id { get; set; }
    public string title { get; set; }
    public string text { get; set; }
    public string url { get; set; }
    public string photo { get; set; }
    public string video { get; set; }
    public string audio { get; set; }
    public string document { get; set; }
    public string category { get; set; }
    public int? member_id { get; set; }
    public int? committee_id { get; set; }
    public Member member { get; set; }
    public Committee committee { get; set; }
}


    public class Committee
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public string Image { get; set; }
    public int CreatedBy { get; set; }
    public string CreatedByName { get; set; }
    public string CreatedByEmail { get; set; }
    public int LastUpdatedBy { get; set; }
    public string LastUpdatedByName { get; set; }
    public string LastUpdatedByEmail { get; set; }
    public DateTime LastUpdated { get; set; }
    public int Parliament { get; set; }
    public int Session { get; set; }
    public int Provisional { get; set; }
    public int Sort { get; set; }
    public int Group { get; set; }
    public string GroupName { get; set; }
    public string GroupUrl { get; set; }
    public string Acronym { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Website { get; set; }
    public string Address { get; set; }
    public int ReportPeriod { get; set; }
    public int ReportYear { get; set; }
    public string ReportUrl { get; set; }
    public string ContactPerson { get; set; }
    public string ContactEmail { get; set; }
    public string ContactPhone { get; set; }
}

public class CommitteeMeeting
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Venue { get; set; }
    public int Committee { get; set; }
    public string CommitteeName { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public int CreatedBy { get; set; }
    public string CreatedByName { get; set; }
    public string CreatedByEmail { get; set; }
    public int LastUpdatedBy { get; set; }
    public string LastUpdatedByName { get; set; }
    public string LastUpdatedByEmail { get; set; }
    public DateTime LastUpdated { get; set; }
    public string Outcome { get; set; }
    public string VenueLink { get; set; }
    public int Provisional { get; set; }
}

public class CommitteeQuestion
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Summary { get; set; }
    public DateTime Published { get; set; }
    public DateTime LastUpdated { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public int CreatedBy { get; set; }
    public string CreatedByName { get; set; }
    public string CreatedByEmail { get; set; }
    public int PublishedBy { get; set; }
    public string PublishedByName { get; set; }
    public string PublishedByEmail { get; set; }
    public int LastUpdatedBy { get; set; }
    public string LastUpdatedByName { get; set; }
    public string LastUpdatedByEmail { get; set; }
    public int Parliament { get; set; }
    public int Session { get; set; }
    public int Provisional { get; set; }
    public int AnswerType { get; set; }
    public string AnswerTypeName { get; set; }
    public int RepliedTo { get; set; }
    public int Meeting { get; set; }
    public int Order { get; set; }
    public int Speaker { get; set; }
    public int SpeakerTitle { get; set; }
    public string SpeakerName { get; set; }
    public string SpeakerParty { get; set; }
    public string SpeakerProvince { get; set; }
    public int SpeakerPosition { get; set; }
    public string SpeakerPositionName { get; set; }
    public string SpeakerGender { get; set; }
    public int Addressee { get; set; }
    public int AddresseeTitle { get; set; }
    public string AddresseeName { get; set; }
    public string AddresseeParty { get; set; }
    public string AddresseeProvince { get; set; }
    public int AddresseePosition { get; set; }
    public string AddresseePositionName { get; set; }
    public string AddresseeGender { get; set; }
    public int ParliamentQuestionNumber { get; set; }
    public string QuestionNumber { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public int Portfolio { get; set; }
    public string PortfolioName { get; set; }
    public int Committee { get; set; }
    public string CommitteeName { get; set; }
    public int Tag { get; set; }
    public string TagName { get; set; }
}
public class DailySchedule
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public DateTime LastUpdated { get; set; }
    public int CreatedBy { get; set; }
    public string CreatedByName { get; set; }
    public string CreatedByEmail { get; set; }
    public int LastUpdatedBy { get; set; }
    public string LastUpdatedByName { get; set; }
    public string LastUpdatedByEmail { get; set; }
    public DateTime Date { get; set; }
    public int Provisional { get; set; }
    public int Parliament { get; set; }
    public int Session { get; set; }
    public int House { get; set; }
}

public class Gazette
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Summary { get; set; }
    public DateTime Published { get; set; }
    public DateTime LastUpdated { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public int CreatedBy { get; set; }
    public string CreatedByName { get; set; }
    public string CreatedByEmail { get; set; }
    public int PublishedBy { get; set; }
    public string PublishedByName { get; set; }
    public string PublishedByEmail { get; set; }
    public int LastUpdatedBy { get; set; }
    public string LastUpdatedByName { get; set; }
    public string LastUpdatedByEmail { get; set; }
    public int GazetteType { get; set; }
    public string GazetteTypeName { get; set; }
    public int Parliament { get; set; }
    public int Session { get; set; }
    public int Provisional { get; set; }
}

 
    public class File
    {
        public int id { get; set; }
        public string title { get; set; }
        public string file_mime { get; set; }
        public string file_path { get; set; }
        public int file_bytes { get; set; }
        public object origname { get; set; }
        public object description { get; set; }
        public object playtime { get; set; }
        public string url { get; set; }
    }

    public class PolicyDocument
    {
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string effective_date { get; set; }
        public string start_date { get; set; }
        public object nid { get; set; }
        public string url { get; set; }
        public List<File> files { get; set; }
    }


}