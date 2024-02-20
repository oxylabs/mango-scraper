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