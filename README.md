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

### Sample project migration

Coming soon!

### Empty project migration

Coming soon!

## Content administration

**Note:** Managing the content when using *our* sample site project Id is not possible.

After using either the "Empty project" or "Sample project" migrations above, you can manage your content by: 

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
