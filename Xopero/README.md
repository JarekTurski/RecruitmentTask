The Xopero app provides simple UI for issue management on the Github.

Current implementation allows:
- adding a new issue (with name and description defined by the user)
- modifying an issue's name and description
- closing an issue
- exporting all issues to a file
- importing issues from a file to the repository

# Getting started

appsettings must contain following fields:
```json
{
  "Github": {
    "GetIssuesEndpoint": "",
    "CreateIssueEndpoint": "",
    "UpdateIssueEndpoint": "",
    "CloseIssueEndpoint": "",
    "DataToUploadPath": "",
    "DataToSavePath": ""
  }
}
```

Each endpoint should follow the schema described at https://docs.github.com/en/rest/issues/issues?apiVersion=2022-11-28

Gitlab API docu: https://docs.gitlab.com/ee/api/issues.html#list-project-issues

# IMPORTANT

To execute any operation that modifies/creates/closes issue requires authentication.
The Client does not support token creation, user has to provide token manually
-> GithubClient class, line 57.

# What's next?
- Unit tests
- Authentication to the repository provider using proper service instead of copy-paste   
- Depending on project next steps, some common logic could be extracted to HostingServiceClientBase


 