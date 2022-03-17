# ABP-blazor-with-Orchard-backend
A demonstration for ABP Blazor wasm authentication via using OpenIdDict which is implemented by Orchard.


## Getting Started

1. Run a mysql instance on Docker with following command
   ```bash
   docker run --name tmp-mysql --restart unless-stopped -e 'MYSQL_ROOT_PASSWORD=12345678Aa' -p 3306:3306 -d mysql:5.7
   ```
2. Run `orchard/Acme.BookStore/Acme.BookStore.csproj`
4. Navigate to [localhost:5001](https://localhost:5001) if you see 
5. Navigate to `/Admin` path and log in with super user that you've configured before
6. Go to `Features` page from menu and activate all **OpenId** features. _(you can search for 'OpenId' in the page. Because the list is long)_
7. Then refresh page you'll see **OpenID Connect** menu under **Security**. Navigate to `Scopes` menu and add following scopes: `email`, `openid`, `profile`, `role`, `phone`, `address`, `BookStore`.
   ![openid-scopes](content/images/openid-scopes.png)
8. Navigate to `Applications` and create an application for `BookStore_Blazor`. _Make sure your parameters must match with following parameters_
   ![openid-applications-parameteres](content/images/openid-applications-parameteres.png)
9.  Run both `abp/src/Acme.BookStore.Blazor/Acme.BookStore.Blazor.csproj` and `abp/src/Acme.BookStore.HttpApi.Host/Acme.BookStore.HttpApi.Host.csproj`.
10. Navigate to [localhost:44307](https://localhost:44307) and try to log in.