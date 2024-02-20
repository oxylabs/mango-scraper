<?php

$params = [
    'source' => 'universal_ecommerce',
    'url' => 'https://shop.mango.com/lt/men?gad_source=1&gclid=cjwkcaiaungubhakeiwagid4akiddksf_zk7lumx_nottzazyf1w3isfgemq2iutuocip9yuq_qmzhochoyqavd_bwe&gclsrc=aw.ds',
];

$ch = curl_init();

curl_setopt($ch, CURLOPT_URL, "https://realtime.oxylabs.io/v1/queries");
curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
curl_setopt($ch, CURLOPT_POSTFIELDS, json_encode($params));
curl_setopt($ch, CURLOPT_POST, 1);
curl_setopt($ch, CURLOPT_USERPWD, "user" . ":" . "pass1");

$headers = array();
$headers[] = "Content-Type: application/json";
curl_setopt($ch, CURLOPT_HTTPHEADER, $headers);

$result = curl_exec($ch);
echo $result;

if (curl_errno($ch)) {
    echo 'Error:' . curl_error($ch);
}
curl_close ($ch);
?>