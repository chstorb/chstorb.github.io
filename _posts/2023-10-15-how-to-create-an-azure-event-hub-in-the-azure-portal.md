---
layout: post
title: "How to Create an Azure Event Hub in the Azure Portal"
date: 2023-10-15
categories: [Azure]
tags: [Azure Event Hubs]
description: "To create an Azure Event Hub in the Azure portal, follow these steps."
author: "Christian Storb"
image: /assets/images/consulting/blog/artificial-intelligence-3382507_1920.jpg
locale: "en_US"
seo: 
  type: BlogPosting  
---

To create an Azure Event Hub in the Azure portal, follow these steps:

- Sign in to the Azure portal.
- Create a resource group by selecting <strong>Resource groups</strong> from the left navigation pane, then selecting <strong>Create</strong>.
- Enter a unique name for the resource group and select a region for it.
- Create an Event Hubs namespace by selecting <strong>All services</strong> from the left navigation pane, then typing "Event Hubs" in the search bar and selecting <strong>Event Hubs</strong> from the results.
- Select <strong>Create</strong> on the toolbar, then enter a name for the namespace and select a region for it.
- Choose the pricing tier (Basic or Standard) and leave the throughput units settings as they are.
- Create an event hub within the namespace by selecting <strong>+ Event hub</strong> on the command bar of the Overview page for your namespace.
- Enter a name for your event hub and select <strong>Review + create</strong>.  


That's it! You have successfully created an Azure Event Hub in the Azure portal. If you need more information about Event Hubs, you can check out <a href="https://docs.microsoft.com/en-us/azure/event-hubs/event-hubs-about" target="_blank">Microsoft's documentation</a>.

## References

- [How to create an Azure Event Hub in the Azure portal - Microsoft Learn](https://learn.microsoft.com/en-us/azure/event-hubs/event-hubs-create-portal).
