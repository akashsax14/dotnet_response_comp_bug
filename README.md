Reproducer for potential bug in ASP.NET Core Response Compression Middleware

Bug: When using response compression middleware, response headers for GET and HEAD requests are not same when Accept-Encoding is set as "gzip"

Description: When response compression middleware is used and a GET/HEAD request is made with Accept-Encoding header set as "gzip", the response to GET request contains the Content-Encoding header with value "gzip" and no Content-Length header but the response to HEAD request contains no Content-Encoding header with Content-Length header value as the uncompressed content length.

Reproducer:
1. Run the ASP.NET Core application using ResponseCompBug launch profile
2. Open postman or similar api testing application and make the following requests with Accept-Encoding header as gzip
  - GET https://localhost:5001/api/values
  - HEAD https://localhost:5001/api/values
3. Expect to get same headers for GET and HEAD but are not
