# VW Test Calculator API

**Task**: VW-06
**Purpose**: End-to-end workflow test
**Status**: Testing complete workflow from kanban → code → PR → review

## Features

- ✅ Add endpoint
- ✅ Subtract endpoint
- ✅ Multiply endpoint
- ✅ Divide endpoint (with zero check)
- ✅ XML documentation

## API Endpoints

```
GET /api/calculator/add?a=5&b=3        → 8
GET /api/calculator/subtract?a=5&b=3  → 2
GET /api/calculator/multiply?a=5&b=3  → 15
GET /api/calculator/divide?a=6&b=3    → 2
```

## Run

```bash
cd CalculatorAPI
dotnet run
```

## Test

```bash
curl "http://localhost:5000/api/calculator/add?a=10&b=5"
```

---

**This is a TEST project** - Will be deleted after workflow verification.
