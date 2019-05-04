# Basel
Web application for financial analyses and planning (e.g. private expenses, invests)

## Idea
Application to organize, plan and analyze (private) finances. The application gets an overview of regularl expenses, income. It allows to classify and plan expenses. It is basically to organize your private finances stuff.

In order to support multiplatform environment the UI is provided as webfrontend. The backend is implemented as .NET Core Web API and data is stored in a MongoDB database.


## Technologies

* Backend: C# .NET Core
* Frontend: Angular
* Data: MongoDB

## Toolchain
* Visual Studio
* Visual Studio Code
* Docker
* Powershell

## Use Cases
### Data input
Raw data is exported from banking application.
Format is csv.
Exported raw data should contain enough information to meet data model below.

The exported data is processed to allow an database input of normalized data.

### Teaching
Based on imported rawdata a teaching process will be done to assign finacial expenses to specific categories (nourishment, toiletries, insurance, refueling etc.).

This categories are manually defined during training process.

### Analyzes
With processed data the application allowes for example to analyze how many expenses during specific timespan were spend on what.

Also aggregated analyzes like how much expenses are there for a specific time overall.

## Data Models
### Expenses
Properties

|Name|Type|
|---|---|
|BookingDate|DateTime|
|ProcessDate|DateTime|
|Category|String|
|Amount|Decimal|
|Description|String|
