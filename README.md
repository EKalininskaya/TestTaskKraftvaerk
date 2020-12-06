TestTaskKraftvaerk
================================
This test application was created for a job interview in Kraftvaerk.

## How to build
Use the command: dotnet build in the solution folder.

## How to run the tests
Use the command: dotnet test in the solution folder.

## Supported browsers
Following browsers are supported.
1. 'chrome' - Chrome (at least version 87 is required). Used by default.
2. 'headless chrome' - Headless Chrome (with FullHD resolution).
3. 'firefox' - Firefox (gecko driver installed is required).

The driver can be specified in the config file (appconfig.json) as 'browser'.

## Restrictions
The test is supposed to work on desktop only (mobile view is not supported).