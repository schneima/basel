# Basel
Web application for financial analyzes and planning (e.g. private expenses, invests)

## Idea
Application to organize, plan and analyze (private) finances. The application gets an overview of regularl expenses, income. It allows to classify and plan expenses. It is basically to organize your private finances stuff.

In order to support multiplatform environment the UI is provided as webfrontend. The backend is implemented as .NET Core Web API and data is stored in a MongoDB database.

It is possible to analyze expenses from differenz accounts.

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

There are differnt Parser handling different kind of exports. Differnt implementation can be done e.g. for different financial institutes. For each parser column indices are defined to meet data model definitions. 

The exported data is processed to allow an database input of normalized data.
Normalized data is put into database.

### Teaching
Based on imported rawdata a teaching process will be done to assign finacial expenses to specific categories (nourishment, toiletries, insurance, refueling etc.).

This categories are manually defined during training process.

Raw data is extended by manually collected category data. 

### Analyzes
With processed data the application allowes for example to analyze how many expenses during specific timespan were spend on what.

Also aggregated analyzes like how much expenses are there for a specific time overall.

Via dynamic filtering it is possiple to analyze just a specific category of expenses.

## Data Models


### Expenses
Properties

|Name|Type|Description|
|---|---|---|
|AccountId|Integer|Identifier to link expense to a specific account|
|BookingDate|DateTime|Date of expense|
|ProcessDate|DateTime|Date whenn expense was processed|
|Category|String|User defined category for better sorting and analyzing of expense|
|Amount|Decimal|...|
|Bookingtext|String|Original text by export|
|Description|String|Optional user defined text giving context to expense helping to|
