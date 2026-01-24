---
layout: post
title: "Update ECDSA Host Key"
date: 2023-10-15 20:04:01 +0100
categories: [Raspberry Pi]
description: "To update the ECDSA host key, you can remove the cached key for the IP address of the server on your local machine using the following command: ssh-keygen -R ..."
tags: [Raspberry Pi]
author: "Christian Storb"
locale: "en_US"
image: /assets/images/consulting/blog/kontobestaetigung-identity.jpg
seo:
  type: BlogPosting
---

To update the ECDSA host key, you can remove the cached key for the IP address of the server on your local machine using the following command: 

```bash
ssh-keygen -R <IP address>
```

This will remove the old key from your known_hosts file.

Alternatively, you can update the key instead of removing it by using 

```bash
ssh-keyscan -t ecdsa <server domain or IP address> >> ~/.ssh/known_hosts
```

This will add the new key to your known_hosts file and hash the hostname/address.
