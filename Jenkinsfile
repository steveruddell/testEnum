pipeline {
  agent any
  stages {
    stage('Initialize') {
      steps {
        git(url: 'https://github.com/steveruddell/testEnum', branch: 'master', credentialsId: 'steveruddell')
        bat(script: 'msbuild', returnStatus: true)
      }
    }
  }
}