## Use Cases Project

클린 아키텍처에서 사용 사례(또는 애플리케이션 서비스) 프로젝트는 도메인 모델을 감싸는 비교적 얇은 레이어입니다.

사용 사례는 일반적으로 기능별로 구성됩니다. 이는 단순한 CRUD 작업일 수도 있고 훨씬 더 복잡한 활동일 수도 있습니다.

사용 사례는 인프라 문제에 직접적으로 의존해서는 안 되므로 대부분의 경우 단위 테스트가 간단합니다.

사용 사례는 종종 CQRS에 따라 명령 및 쿼리로 그룹화됩니다.

사용 사례를 별도의 프로젝트로 만들면 UI 및 인프라 프로젝트에서 로직의 양을 줄일 수 있습니다.

간단한 프로젝트의 경우, 사용 사례 프로젝트를 생략하고 해당 동작을 별도의 서비스 또는 MediatR 핸들러로 UI 프로젝트로 이동하거나 단순히 로직을 API 엔드포인트에 넣을 수 있습니다.

사용 사례 프로젝트의 폴더 구조 구성에 대한 아이디어는 이 스레드를 참조하세요:

Translated with www.DeepL.com/Translator (free version)
https://twitter.com/ardalis/status/1686406393018945536

Need help? Check out the sample here:
https://github.com/ardalis/CleanArchitecture/sample

Still need help?
Contact us at https://nimblepros.com
