#Dasha

UnityのHTTP/WSのfake IOを監視して、適当なフィルタと返り値を設定できるツール。
いちいちダミーサーバ書くのしんどいのでなんかバイナリマッチとかでフィルタ書けるようにしたい。

実態はオブザーバ + コードジェネレータ。不本意だ。  
わりと開発中。

打者です。


## draft of usage

1. write fake data-output near by your IO code.
1. Dasha observe that.
1. see the list of Dasha received datas, then push "Add Reflector".
1. choose the key of handle. url + header + payload(http), url + opcode + payload(ws).
1. also set desired response. 
1. Dasha generates new Reflector.cs code by setting.
1. after setting, if fake data-output matches to Dasha's filter, Dasha 