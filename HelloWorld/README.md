# HelloWorld .NET 8.0 프로젝트

## 윈도우에서 실행하는 방법

### 방법 1: 미리 빌드된 실행 파일 사용 (권장)
1. `windows-exe` 폴더에서 `HelloWorld.exe` 직접 실행

### 방법 2: 배치 파일 사용
1. `windows-build.bat` 파일을 더블클릭하여 실행
2. 빌드가 완료되면 `windows-exe` 폴더에서 `HelloWorld.exe` 실행

### 방법 3: 명령 프롬프트 사용
```cmd
dotnet publish -c Release -r win-x64 --self-contained false -o ./windows-exe
cd windows-exe
HelloWorld.exe
```

### 방법 3: 직접 실행 (닷넷 런타임 필요)
```cmd
dotnet run
```

## 요구사항
- .NET 8.0 Runtime이 윈도우 VM에 설치되어 있어야 합니다.
- 다운로드: https://dotnet.microsoft.com/download/dotnet/8.0