# JWT Authentication Demo

This project showcases usage of JWT in asp.net Core application.

It was following this guide:
- [Part I](https://goblincoding.com/2016/07/03/issuing-and-authenticating-jwt-tokens-in-asp-net-core-webapi-part-i/)
- [Part II](https://goblincoding.com/2016/07/07/issuing-and-authenticating-jwt-tokens-in-asp-net-core-webapi-part-ii/)

It was supported by these sources:
- ["JWT- sub" is equivalent to ".net - nameidentifier", what is it?](http://stackoverflow.com/questions/5814017/what-is-the-purpose-of-nameidentifier-claim)
- [Getting current user Id](http://stackoverflow.com/questions/38751616/asp-net-core-identity-get-current-user)
- [Adding roles](http://stackoverflow.com/questions/42036810/asp-net-core-jwt-mapping-role-claims-to-claimsidentity)
    - Proceed with caution, roles should be added with normal string "role" not using ClaimTypes.Role. It still works but takes more space and may not be compatible with server that is not asp.net core.

