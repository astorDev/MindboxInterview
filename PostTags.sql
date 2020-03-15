SELECT p.Title, t.Content
FROM Posts p
LEFT JOIN PostTags pt ON p.Id = pt.PostId
LEFT JOIN Tags t ON t.Id = pt.TagId