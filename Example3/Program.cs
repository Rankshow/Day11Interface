using Example3;

IEmployer employer = new FullTime();
ShowReview(employer);

static void ShowReview(IEmployer jobs)
{
    string[] description = new string[] {"Survey", "Brainstorming", "Collate ideas", "summary"};
    int[] items = new int[] { 02, 9, 19, 10};

    jobs.Project(description);
    jobs.Manager(items);
}
