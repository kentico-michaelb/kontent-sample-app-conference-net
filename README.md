# Kentico Kontent ASP.NET Core MVC Conference Web Application

This is a sample website written in .NET Core 2.2 that uses the Kentico Kontent Delivery .NET SDK to manage and retrieve content from Kentico Kontent. 
The sample site demonstrates how to use Kentico Kontent to create and manage a conference website including support for: multiple events, agendas, speaker biographies, venue descriptions, and registrations using a HubSpot form.

You can see the site in action at: https://konnections.herokuapp.com/

## Application setup

### Running in an IDE

To run the app:
1. Clone the app repository with your favorite GIT client
   1. For instance, you can use [Visual Studio](https://www.visualstudio.com/vs/), [Visual Studio Code](https://code.visualstudio.com/), [GitHub Desktop](https://desktop.github.com/), etc.
   1. Alternatively, you can download the repo as a ZIP file, but this will not adapt the line endings in the downloaded files to your platform (Windows, Unix).
1. Open the solution in your IDE (using the _kontent-sample-app-conference-net_ file).
1. Run the app.

### Connecting to our sample project

1. Open the `~/kontent-sample-app-conference-net/appsettings.json` file.
2. Ensure `DeliveryOptions` contains the project ID:

```json
  "DeliveryOptions": {
    "ProjectId": "db96e910-edf8-0094-b795-f3ce073c7ae0"
  }
```
3. Save any changes.
4. Run the application

### Connecting to your project manually

1. In Kentico Kontent, choose Project settings from the app menu.
2. Under Development, choose API keys.
    * You will be copying the Project ID
    
3. Open the `~/kontent-sample-app-conference-net/appsettings.json` file.
4. Replace project ID in `DeliveryOptions`:

```json
  "DeliveryOptions": {
    "ProjectId": "YOUR_PROJECT_ID"
  }
```
5. Save the changes.
6. Run the application.

### Enabling the Preview Delivery API

1. Follow the "Connecting to your project manually" instructions above.
2. In step 2, copy the Preview API Primary key.
    
3. Open the `~/kontent-sample-app-conference-net/appsettings.json` file.
4. Add `UsePreviewApi` and `PreviewApiKey` keys to `DeliveryOptions` in the configuration:

```json
  "DeliveryOptions": {
    "ProjectId": "YOUR_PROJECT_ID",
    "UsePreviewApi": true,
    "PreviewApiKey": "YOUR_DELIVERY_PREVIEW_API_KEY"
  }
```
5. Save the changes.
6. Run the application.

## Migration scripts

**Note:** migrating a copy of the sample site requires access to the [Management API](https://docs.kontent.ai/reference/management-api-v2) available in the Trial, Business, or Enterprise plans. Please check your [subscription](https://docs.kontent.ai/tutorials/manage-subscriptions-and-user-accounts/subscriptions/checking-your-usage-report) to verify your tier.

A Migration tool for a copying this sample site to your subscription is available here: https://github.com/pokornyd/konference-migration-scripts . This two provides two options:

* A "Full" copy that includes Content Types, Taxnomies, Assets, and Content Items
* A "Minimal" copy that includes Content Types and Taxnomies, but no Content Items or Assets
	
The "Full" copy is a working example containing three conferences and is meant for demonstration or as a reference.
The "Minimal" copy acts a clean boilerplate that you can use to create your own conference site.

Prior to running the tool you will need to: 
1. [Create a new project](https://docs.kontent.ai/tutorials/set-up-projects/manage-projects/managing-projects#a-creating-projects) in your Kentico Kontent subscription
2. In Kentico Kontent, choose Project settings from the app menu.
3. Under Development, choose API keys.
    * You will be copying the Project ID and Management API key.
    
When running the tool, follow the console prompts and copy paste in the respective keys. The application will notify you when the migration has completed with the message "Migration finished."

## Content administration

**Note:** Managing the content when using *our* sample site project Id is not possible.

After using either the "Full" or "Minimal" migrations above, you can manage your content by: 

1. Navigating to <https://app.kontent.ai> in your browser.
2. Signing in with your credentials.
3. Managing content in the content administration interface of your migrated project.

You can learn more about content editing with Kentico Kontent in our [Help Center](https://docs.kontent.ai/).
Instructions for managing the Conference site's content can also be seen here: [Managing the sample conference site](https://github.com/kentico-michaelb/kontent-sample-app-conference-net/wiki/Managing-the-sample-conference-site)

## Content delivery

You can retrieve content through the Kentico Kontent Delivery SDK or the Kentico Kontent Delivery API:

* For published content, use `https://deliver.kontent.ai/PROJECT_ID/items`.
* For unpublished content, use `https://preview-deliver.kontent.ai/PROJECT_ID/items`.

For more details about Kentico Kontent APIs, see our [API reference](https://docs.kontent.ai/reference/kentico-kontent-apis-overview).
For details about the Kentico Konten .NET SDK used throughout this project, please see the [Kentico Kontent Delivery .NET SDK ReadMe](https://github.com/Kentico/kontent-delivery-sdk-net#kentico-kontent-delivery-net-sdk)

## Edit mode

Edit mode has been enabled on the "Home" and "Agenda" pages in the sample site using the steps from the Kontent documentation here: [Editing content directly from your app](https://docs.kontent.ai/tutorials/write-and-collaborate/preview-content/editing-content-directly-from-your-app). 

Editing an item in Kontent requires the user to be [added to the project](https://docs.kontent.ai/tutorials/set-up-projects/manage-your-team/inviting-and-deactivating-users#a-inviting-a-new-user) and logged in to Kentico Kontent.
