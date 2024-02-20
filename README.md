# Mango Scraper API

[![Oxylabs promo code](https://user-images.githubusercontent.com/129506779/250792357-8289e25e-9c36-4dc0-a5e2-2706db797bb5.png)](https://oxylabs.go2cloud.org/aff_c?offer_id=7&aff_id=877&url_id=112)

Oxylabs' [Mango Scraper](https://oxylabs.io/products/scraper-api/ecommerce/mango?utm_source=github&utm_medium=repositories&utm_campaign=product) is a data gathering solution allowing you to extract real-time information from an Mango website effortlessly. This brief guide showcases how Mango Scraper works, along with code examples to help you better understand how to use it hassle-free.

### How it works

You can get Mango results by providing your own URLs to our service. We can return the HTML for any page you like.

#### Python code example

The example below illustrates how you can get HTML of Mango page.

```python
import requests
from pprint import pprint

# Structure payload.
payload = {
    'source': 'universal_ecommerce',
    'url': 'https://shop.mango.com/lt/men?gad_source=1&gclid=cjwkcaiaungubhakeiwagid4akiddksf_zk7lumx_nottzazyf1w3isfgemq2iutuocip9yuq_qmzhochoyqavd_bwe&gclsrc=aw.ds'
}

# Get response.
response = requests.request(
    'POST',
    'https://realtime.oxylabs.io/v1/queries',
    auth=('user', 'pass1'),
    json=payload,
)

# Instead of response with job status and results url, this will return the
# JSON response with the result.
pprint(response.json())
```
Find code examples for other programming languages [**here**](https://github.com/oxylabs/mango-scraper/tree/main/code%20examples)

#### Output Example
```json
{
  "results": [
    {
      "content": "<!DOCTYPE html>\n<html class=\"home     \" xmlns=\"http://www.w3.org/1999/xhtml\" lang=\"en\" dir=\"ltr\"><he ... </html>",
      "created_at": "2024-02-20 12:40:47",
      "updated_at": "2024-02-20 12:40:49",
      "page": 1,
      "url": "https://shop.mango.com/lt/men?gad_source=1&gclid=cjwkcaiaungubhakeiwagid4akiddksf_zk7lumx_nottzazyf1w3isfgemq2iutuocip9yuq_qmzhochoyqavd_bwe&gclsrc=aw.ds",
      "job_id": "7165686727284134913",
      "status_code": 200
    }
  ]
}
```
With our Mango Scraper, you can smoothly extract public data from any Mango web page. Gather the necessary nutritional information, such as calories, vitamins, or fiber content, to understand the health benefits and stay ahead in your wellness journey. If you have any queries, contact our dedicated support team through live chat or email us at hello@oxylabs.io.