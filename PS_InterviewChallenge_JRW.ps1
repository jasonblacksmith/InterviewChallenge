#API tests for Interview Challenge 3/10/2022 JRW

# GET for Information Challenge
Write-Information -MessageData "GET for Information Challenge -- " -InformationAction Continue
$response = Invoke-RestMethod 'https://si-interview-api.azurewebsites.net/api/Information/Challenge' -Method 'GET' -Headers $headers
$response | ConvertTo-Json;

# GET for WeatherForecast
Write-Information -MessageData "GET for WeatherForecast -- " -InformationAction Continue
$response = Invoke-RestMethod 'https://si-interview-api.azurewebsites.net/api/WeatherForecast/WeatherForecast' -Method 'GET' -Headers $headers
$response | ConvertTo-Json;

# POST for WeatherForecast
Write-Information -MessageData "POST for WeatherForecast -- " -InformationAction Continue
$headers = New-Object "System.Collections.Generic.Dictionary[[String],[String]]"
$headers.Add("accept", "text/plain")
$headers.Add("Content-Type", "application/json")

$body = "{
`n  `"id`": 0,
`n  `"date`": `"2022-03-14T04:50:49.046Z`",
`n  `"temperatureC`": 10,
`n  `"summary`": `"string`",
`n  `"location`": `"string`"
`n}"

$response = Invoke-RestMethod 'https://si-interview-api.azurewebsites.net/api/WeatherForecast/WeatherForecast' -Method 'POST' -Headers $headers -Body $body
$response | ConvertTo-Json;

# PUT for WeatherForecast (supposed to be by id but only does id:0 everytime???)
Write-Information -MessageData "PUT for WeatherForecast -- " -InformationAction Continue
$headers = New-Object "System.Collections.Generic.Dictionary[[String],[String]]"
$headers.Add("accept", "text/plain")
$headers.Add("Content-Type", "application/json")

$body = "{
`n  `"id`":0,
`n  `"date`": `"2022-03-11T05:21:31.694Z`",
`n  `"temperatureC`": 0,
`n  `"summary`": `"string`",
`n  `"location`": `"string`"
`n}"

$response = Invoke-RestMethod 'https://si-interview-api.azurewebsites.net/api/WeatherForecast/WeatherForecast' -Method 'PUT' -Headers $headers -Body $body
$response | ConvertTo-Json;

# GET for WeatherForecast by Location
Write-Information -MessageData "GET for WeatherForecast by Location -- " -InformationAction Continue
$response = Invoke-RestMethod 'https://si-interview-api.azurewebsites.net/api/WeatherForecast/WeatherForecast/Brazil' -Method 'GET' -Headers $headers
$response | ConvertTo-Json;

# DELETE for WeatherForecast by ID(update ID to valid value each running(decrement by 1???))
Write-Information -MessageData "DELETE for WeatherForecast by ID -- " -InformationAction Continue
$response = Invoke-RestMethod 'https://si-interview-api.azurewebsites.net/api/WeatherForecast/WeatherForecast/637825710798870055' -Method 'DELETE' -Headers $headers
$response | ConvertTo-Json;