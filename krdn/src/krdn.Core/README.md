## Core (Domain Model) Project

클린 아키텍처에서는 엔티티와 비즈니스 규칙에 중점을 두어야 합니다.

도메인 중심 설계에서는 이것이 도메인 모델입니다.

이 프로젝트에는 모든 엔티티, 가치 객체 및 비즈니스 로직이 포함되어야 합니다.

서로 연관되어 있고 함께 변경되어야 하는 엔티티는 집합체로 그룹화해야 합니다.

엔티티는 캡슐화를 활용해야 하며 공용 세터를 최소화해야 합니다.

엔티티는 도메인 이벤트를 활용하여 시스템의 다른 부분에 변경 사항을 전달할 수 있습니다.

엔티티는 쿼리하는 데 사용할 수 있는 사양을 정의할 수 있습니다.

변경 가능한 액세스의 경우, 엔티티는 리포지토리 인터페이스를 통해 액세스해야 합니다.

읽기 전용 임시 쿼리는 도메인 모델을 사용하지 않는 별도의 쿼리 서비스를 사용할 수 있습니다.

도움이 필요하신가요? 여기에서 샘플을 확인하세요:

Translated with www.DeepL.com/Translator (free version)
https://github.com/ardalis/CleanArchitecture/sample

Still need help?
Contact us at https://nimblepros.com
