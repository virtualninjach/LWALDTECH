



<!DOCTYPE html>
<html lang="en" class="">
  <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# object: http://ogp.me/ns/object# article: http://ogp.me/ns/article# profile: http://ogp.me/ns/profile#">
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Language" content="en">
    
    
    <title>impress.js/README.md at master · bartaz/impress.js</title>
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub">
    <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub">
    <link rel="apple-touch-icon" sizes="57x57" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="114x114" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="72x72" href="/apple-touch-icon-144.png">
    <link rel="apple-touch-icon" sizes="144x144" href="/apple-touch-icon-144.png">
    <meta property="fb:app_id" content="1401488693436528">

      <meta content="@github" name="twitter:site" /><meta content="summary" name="twitter:card" /><meta content="bartaz/impress.js" name="twitter:title" /><meta content="impress.js - It&amp;#39;s a presentation framework based on the power of CSS3 transforms and transitions in modern browsers and inspired by the idea behind prezi.com." name="twitter:description" /><meta content="https://avatars3.githubusercontent.com/u/83575?v=2&amp;s=400" name="twitter:image:src" />
<meta content="GitHub" property="og:site_name" /><meta content="object" property="og:type" /><meta content="https://avatars3.githubusercontent.com/u/83575?v=2&amp;s=400" property="og:image" /><meta content="bartaz/impress.js" property="og:title" /><meta content="https://github.com/bartaz/impress.js" property="og:url" /><meta content="impress.js - It&#39;s a presentation framework based on the power of CSS3 transforms and transitions in modern browsers and inspired by the idea behind prezi.com." property="og:description" />

      <meta name="browser-stats-url" content="/_stats">
    <link rel="assets" href="https://assets-cdn.github.com/">
    <link rel="conduit-xhr" href="https://ghconduit.com:25035">
    <link rel="xhr-socket" href="/_sockets">
    <meta name="pjax-timeout" content="1000">

    <meta name="msapplication-TileImage" content="/windows-tile.png">
    <meta name="msapplication-TileColor" content="#ffffff">
    <meta name="selected-link" value="repo_source" data-pjax-transient>
      <meta name="google-analytics" content="UA-3769691-2">

    <meta content="collector.githubapp.com" name="octolytics-host" /><meta content="collector-cdn.github.com" name="octolytics-script-host" /><meta content="github" name="octolytics-app-id" /><meta content="4BBA9EC1:44A1:9461F7C:545907B7" name="octolytics-dimension-request_id" /><meta content="8811557" name="octolytics-actor-id" /><meta content="virtualninjach" name="octolytics-actor-login" /><meta content="4eb306aa93715b4a96cfa07206d7a57eb6fbed0ed5b48979cf02791d15e2819b" name="octolytics-actor-hash" />
    
    <meta content="Rails, view, blob#show" name="analytics-event" />

    
    
    <link rel="icon" type="image/x-icon" href="https://assets-cdn.github.com/favicon.ico">


    <meta content="authenticity_token" name="csrf-param" />
<meta content="ew3xT+s18p+K9nF7JGEyS/J92Dba4+x0o2r4tsR220EUAtJ94j/uC2OT1dYuxfGPwDb3wrLD0Y0HPulrDAlVEw==" name="csrf-token" />

    <link href="https://assets-cdn.github.com/assets/github-b060a793a729e74df646ac4a533ca91a1a6da47563a3b5dfd69d06e78875c57c.css" media="all" rel="stylesheet" type="text/css" />
    <link href="https://assets-cdn.github.com/assets/github2-83eca2f5a57f3eeeea7945abc6de1830c83a55bac22056acfdcb8a82399d4014.css" media="all" rel="stylesheet" type="text/css" />
    
    


    <meta http-equiv="x-pjax-version" content="40893af65badeb10530c1f14fda986ae">

      
  <meta name="description" content="impress.js - It&#39;s a presentation framework based on the power of CSS3 transforms and transitions in modern browsers and inspired by the idea behind prezi.com.">
  <meta name="go-import" content="github.com/bartaz/impress.js git https://github.com/bartaz/impress.js.git">

  <meta content="83575" name="octolytics-dimension-user_id" /><meta content="bartaz" name="octolytics-dimension-user_login" /><meta content="3065454" name="octolytics-dimension-repository_id" /><meta content="bartaz/impress.js" name="octolytics-dimension-repository_nwo" /><meta content="true" name="octolytics-dimension-repository_public" /><meta content="false" name="octolytics-dimension-repository_is_fork" /><meta content="3065454" name="octolytics-dimension-repository_network_root_id" /><meta content="bartaz/impress.js" name="octolytics-dimension-repository_network_root_nwo" />
  <link href="https://github.com/bartaz/impress.js/commits/master.atom" rel="alternate" title="Recent Commits to impress.js:master" type="application/atom+xml">

  </head>


  <body class="logged_in  env-production windows vis-public page-blob">
    <a href="#start-of-content" tabindex="1" class="accessibility-aid js-skip-to-content">Skip to content</a>
    <div class="wrapper">
      
      
      
      


      <div class="header header-logged-in true" role="banner">
  <div class="container clearfix">

    <a class="header-logo-invertocat" href="https://github.com/" data-hotkey="g d" aria-label="Homepage" ga-data-click="Header, go to dashboard, icon:logo">
  <span class="mega-octicon octicon-mark-github"></span>
</a>


      <div class="site-search repo-scope js-site-search" role="search">
          <form accept-charset="UTF-8" action="/bartaz/impress.js/search" class="js-site-search-form" data-global-search-url="/search" data-repo-search-url="/bartaz/impress.js/search" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /></div>
  <input type="text"
    class="js-site-search-field is-clearable"
    data-hotkey="s"
    name="q"
    placeholder="Search"
    data-global-scope-placeholder="Search GitHub"
    data-repo-scope-placeholder="Search"
    tabindex="1"
    autocapitalize="off">
  <div class="scope-badge">This repository</div>
</form>
      </div>
      <ul class="header-nav left" role="navigation">
        <li class="header-nav-item explore">
          <a class="header-nav-link" href="/explore" data-ga-click="Header, go to explore, text:explore">Explore</a>
        </li>
          <li class="header-nav-item">
            <a class="header-nav-link" href="https://gist.github.com" data-ga-click="Header, go to gist, text:gist">Gist</a>
          </li>
          <li class="header-nav-item">
            <a class="header-nav-link" href="/blog" data-ga-click="Header, go to blog, text:blog">Blog</a>
          </li>
        <li class="header-nav-item">
          <a class="header-nav-link" href="https://help.github.com" data-ga-click="Header, go to help, text:help">Help</a>
        </li>
      </ul>

    
<ul class="header-nav user-nav right" id="user-links">
  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link name" href="/virtualninjach" data-ga-click="Header, go to profile, text:username">
      <img alt="Chris" class="avatar" data-user="8811557" height="20" src="https://avatars2.githubusercontent.com/u/8811557?v=2&amp;s=40" width="20" />
      <span class="css-truncate">
        <span class="css-truncate-target">virtualninjach</span>
      </span>
    </a>
  </li>

  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link js-menu-target tooltipped tooltipped-s" href="#" aria-label="Create new..." data-ga-click="Header, create new, icon:add">
      <span class="octicon octicon-plus"></span>
      <span class="dropdown-caret"></span>
    </a>

    <div class="dropdown-menu-content js-menu-content">
      
<ul class="dropdown-menu">
  <li>
    <a href="/new"><span class="octicon octicon-repo"></span> New repository</a>
  </li>
  <li>
    <a href="/organizations/new"><span class="octicon octicon-organization"></span> New organization</a>
  </li>


    <li class="dropdown-divider"></li>
    <li class="dropdown-header">
      <span title="bartaz/impress.js">This repository</span>
    </li>
      <li>
        <a href="/bartaz/impress.js/issues/new"><span class="octicon octicon-issue-opened"></span> New issue</a>
      </li>
</ul>

    </div>
  </li>

  <li class="header-nav-item">
        <a href="/notifications" aria-label="You have no unread notifications" class="header-nav-link notification-indicator tooltipped tooltipped-s" data-ga-click="Header, go to notifications, icon:read" data-hotkey="g n">
        <span class="mail-status all-read"></span>
        <span class="octicon octicon-inbox"></span>
</a>
  </li>

  <li class="header-nav-item">
    <a class="header-nav-link tooltipped tooltipped-s" href="/settings/profile" id="account_settings" aria-label="Settings" data-ga-click="Header, go to settings, icon:settings">
      <span class="octicon octicon-gear"></span>
    </a>
  </li>

  <li class="header-nav-item">
    <form accept-charset="UTF-8" action="/logout" class="logout-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="B28nGS7o6ITwVM0/NSs9hM3yXAQsfDpIbbGM70cxVOk5EAvtA69wbrZUEdsoeEy0VTAiRqJ2PQCNx1WoOP0BLw==" /></div>
      <button class="header-nav-link sign-out-button tooltipped tooltipped-s" aria-label="Sign out" data-ga-click="Header, sign out, icon:logout">
        <span class="octicon octicon-sign-out"></span>
      </button>
</form>  </li>

</ul>


    
  </div>
</div>

      

        


      <div id="start-of-content" class="accessibility-aid"></div>
          <div class="site" itemscope itemtype="http://schema.org/WebPage">
    <div id="js-flash-container">
      
    </div>
    <div class="pagehead repohead instapaper_ignore readability-menu">
      <div class="container">
        
<ul class="pagehead-actions">

    <li class="subscription">
      <form accept-charset="UTF-8" action="/notifications/subscribe" class="js-social-container" data-autosubmit="true" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="73+AwiuYOFY13zeYn0OFIycTENa92YNEUHLFiwCmlRw/yME0E5lhQaOdLFLmFNHC2B/4egOLEvr+o0aI9LHB5w==" /></div>  <input id="repository_id" name="repository_id" type="hidden" value="3065454" />

    <div class="select-menu js-menu-container js-select-menu">
      <a class="social-count js-social-count" href="/bartaz/impress.js/watchers">
        1,264
      </a>
      <a href="/bartaz/impress.js/subscription"
        class="minibutton select-menu-button with-count js-menu-target" role="button" tabindex="0" aria-haspopup="true">
        <span class="js-select-button">
          <span class="octicon octicon-eye"></span>
          Watch
        </span>
      </a>

      <div class="select-menu-modal-holder">
        <div class="select-menu-modal subscription-menu-modal js-menu-content" aria-hidden="true">
          <div class="select-menu-header">
            <span class="select-menu-title">Notifications</span>
            <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
          </div> <!-- /.select-menu-header -->

          <div class="select-menu-list js-navigation-container" role="menu">

            <div class="select-menu-item js-navigation-item selected" role="menuitem" tabindex="0">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input checked="checked" id="do_included" name="do" type="radio" value="included" />
                <h4>Not watching</h4>
                <span class="description">Be notified when participating or @mentioned.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-eye"></span>
                  Watch
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

            <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
              <span class="select-menu-item-icon octicon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input id="do_subscribed" name="do" type="radio" value="subscribed" />
                <h4>Watching</h4>
                <span class="description">Be notified of all conversations.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-eye"></span>
                  Unwatch
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

            <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input id="do_ignore" name="do" type="radio" value="ignore" />
                <h4>Ignoring</h4>
                <span class="description">Never be notified.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-mute"></span>
                  Stop ignoring
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

          </div> <!-- /.select-menu-list -->

        </div> <!-- /.select-menu-modal -->
      </div> <!-- /.select-menu-modal-holder -->
    </div> <!-- /.select-menu -->

</form>
    </li>

  <li>
    
  <div class="js-toggler-container js-social-container starring-container ">

    <form accept-charset="UTF-8" action="/bartaz/impress.js/unstar" class="js-toggler-form starred js-unstar-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="UTBo57fuKtvy5WsJXVeCV/sYydStskeavBKFKkrzqtjWJyhflFgtg4tV88CS+oLsPvT/pRsson4FmgpIB3/CvA==" /></div>
      <button
        class="minibutton with-count js-toggler-target star-button"
        aria-label="Unstar this repository" title="Unstar bartaz/impress.js">
        <span class="octicon octicon-star"></span>
        Unstar
      </button>
        <a class="social-count js-social-count" href="/bartaz/impress.js/stargazers">
          22,220
        </a>
</form>
    <form accept-charset="UTF-8" action="/bartaz/impress.js/star" class="js-toggler-form unstarred js-star-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="TP7aLj7A6nHS3s6pEj/xdLvemNqsBndxl8WNF34ZPe8/6PmW+Warhd4Qb0dDXU1UR0cOdiT+ZkyNHTmY4BDGPQ==" /></div>
      <button
        class="minibutton with-count js-toggler-target star-button"
        aria-label="Star this repository" title="Star bartaz/impress.js">
        <span class="octicon octicon-star"></span>
        Star
      </button>
        <a class="social-count js-social-count" href="/bartaz/impress.js/stargazers">
          22,220
        </a>
</form>  </div>

  </li>


        <li>
          <a href="/bartaz/impress.js/fork" class="minibutton with-count js-toggler-target fork-button tooltipped-n" title="Fork your own copy of bartaz/impress.js to your account" aria-label="Fork your own copy of bartaz/impress.js to your account" rel="nofollow" data-method="post">
            <span class="octicon octicon-repo-forked"></span>
            Fork
          </a>
          <a href="/bartaz/impress.js/network" class="social-count">4,657</a>
        </li>

</ul>

        <h1 itemscope itemtype="http://data-vocabulary.org/Breadcrumb" class="entry-title public">
          <span class="mega-octicon octicon-repo"></span>
          <span class="author"><a href="/bartaz" class="url fn" itemprop="url" rel="author"><span itemprop="title">bartaz</span></a></span><!--
       --><span class="path-divider">/</span><!--
       --><strong><a href="/bartaz/impress.js" class="js-current-repository js-repo-home-link" data-pjax-container-selector="#js-repo-pjax-container">impress.js</a></strong>

          <span class="page-context-loader">
            <img alt="" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
          </span>

        </h1>
      </div><!-- /.container -->
    </div><!-- /.repohead -->

    <div class="container">
      <div class="repository-with-sidebar repo-container new-discussion-timeline  ">
        <div class="repository-sidebar clearfix">
            
<nav class="sunken-menu repo-nav js-repo-nav js-sidenav-container-pjax js-octicon-loaders" role="navigation" data-issue-count-url="/bartaz/impress.js/issues/counts" data-pjax-container-selector="#js-repo-pjax-container">
  <ul class="sunken-menu-group">
    <li class="tooltipped tooltipped-w" aria-label="Code">
      <a href="/bartaz/impress.js" aria-label="Code" class="selected js-selected-navigation-item sunken-menu-item" data-hotkey="g c" data-pjax="true" data-selected-links="repo_source repo_downloads repo_commits repo_releases repo_tags repo_branches /bartaz/impress.js">
        <span class="octicon octicon-code"></span> <span class="full-word">Code</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>    </li>

      <li class="tooltipped tooltipped-w" aria-label="Issues">
        <a href="/bartaz/impress.js/issues" aria-label="Issues" class="js-selected-navigation-item sunken-menu-item js-disable-pjax" data-hotkey="g i" data-selected-links="repo_issues repo_labels repo_milestones /bartaz/impress.js/issues">
          <span class="octicon octicon-issue-opened"></span> <span class="full-word">Issues</span>
          <span class="js-issue-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>

    <li class="tooltipped tooltipped-w" aria-label="Pull Requests">
      <a href="/bartaz/impress.js/pulls" aria-label="Pull Requests" class="js-selected-navigation-item sunken-menu-item js-disable-pjax" data-hotkey="g p" data-selected-links="repo_pulls /bartaz/impress.js/pulls">
          <span class="octicon octicon-git-pull-request"></span> <span class="full-word">Pull Requests</span>
          <span class="js-pull-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>    </li>


      <li class="tooltipped tooltipped-w" aria-label="Wiki">
        <a href="/bartaz/impress.js/wiki" aria-label="Wiki" class="js-selected-navigation-item sunken-menu-item js-disable-pjax" data-hotkey="g w" data-selected-links="repo_wiki /bartaz/impress.js/wiki">
          <span class="octicon octicon-book"></span> <span class="full-word">Wiki</span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>
  </ul>
  <div class="sunken-menu-separator"></div>
  <ul class="sunken-menu-group">

    <li class="tooltipped tooltipped-w" aria-label="Pulse">
      <a href="/bartaz/impress.js/pulse/weekly" aria-label="Pulse" class="js-selected-navigation-item sunken-menu-item" data-pjax="true" data-selected-links="pulse /bartaz/impress.js/pulse/weekly">
        <span class="octicon octicon-pulse"></span> <span class="full-word">Pulse</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>    </li>

    <li class="tooltipped tooltipped-w" aria-label="Graphs">
      <a href="/bartaz/impress.js/graphs" aria-label="Graphs" class="js-selected-navigation-item sunken-menu-item" data-pjax="true" data-selected-links="repo_graphs repo_contributors /bartaz/impress.js/graphs">
        <span class="octicon octicon-graph"></span> <span class="full-word">Graphs</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>    </li>
  </ul>


</nav>

              <div class="only-with-full-nav">
                
  
<div class="clone-url open"
  data-protocol-type="http"
  data-url="/users/set_protocol?protocol_selector=http&amp;protocol_type=clone">
  <h3><span class="text-emphasized">HTTPS</span> clone URL</h3>
  <div class="input-group">
    <input type="text" class="input-mini input-monospace js-url-field"
           value="https://github.com/bartaz/impress.js.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard minibutton zeroclipboard-button" data-clipboard-text="https://github.com/bartaz/impress.js.git" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="clone-url "
  data-protocol-type="ssh"
  data-url="/users/set_protocol?protocol_selector=ssh&amp;protocol_type=clone">
  <h3><span class="text-emphasized">SSH</span> clone URL</h3>
  <div class="input-group">
    <input type="text" class="input-mini input-monospace js-url-field"
           value="git@github.com:bartaz/impress.js.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard minibutton zeroclipboard-button" data-clipboard-text="git@github.com:bartaz/impress.js.git" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="clone-url "
  data-protocol-type="subversion"
  data-url="/users/set_protocol?protocol_selector=subversion&amp;protocol_type=clone">
  <h3><span class="text-emphasized">Subversion</span> checkout URL</h3>
  <div class="input-group">
    <input type="text" class="input-mini input-monospace js-url-field"
           value="https://github.com/bartaz/impress.js" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard minibutton zeroclipboard-button" data-clipboard-text="https://github.com/bartaz/impress.js" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>


<p class="clone-options">You can clone with
      <a href="#" class="js-clone-selector" data-protocol="http">HTTPS</a>,
      <a href="#" class="js-clone-selector" data-protocol="ssh">SSH</a>,
      or <a href="#" class="js-clone-selector" data-protocol="subversion">Subversion</a>.
  <a href="https://help.github.com/articles/which-remote-url-should-i-use" class="help tooltipped tooltipped-n" aria-label="Get help on which URL is right for you.">
    <span class="octicon octicon-question"></span>
  </a>
</p>


  <a href="github-windows://openRepo/https://github.com/bartaz/impress.js" class="minibutton sidebar-button" title="Save bartaz/impress.js to your computer and use it in GitHub Desktop." aria-label="Save bartaz/impress.js to your computer and use it in GitHub Desktop.">
    <span class="octicon octicon-device-desktop"></span>
    Clone in Desktop
  </a>

                <a href="/bartaz/impress.js/archive/master.zip"
                   class="minibutton sidebar-button"
                   aria-label="Download the contents of bartaz/impress.js as a zip file"
                   title="Download the contents of bartaz/impress.js as a zip file"
                   rel="nofollow">
                  <span class="octicon octicon-cloud-download"></span>
                  Download ZIP
                </a>
              </div>
        </div><!-- /.repository-sidebar -->

        <div id="js-repo-pjax-container" class="repository-content context-loader-container" data-pjax-container>
          

<a href="/bartaz/impress.js/blob/e2d1eb90bf12a1be02079d74545453164d7e7ec4/README.md" class="hidden js-permalink-shortcut" data-hotkey="y">Permalink</a>

<!-- blob contrib key: blob_contributors:v21:dc39cf45476592fd2b2df418101df2cf -->

<div class="file-navigation">
  
<div class="select-menu js-menu-container js-select-menu left">
  <span class="minibutton select-menu-button js-menu-target css-truncate" data-hotkey="w"
    data-master-branch="master"
    data-ref="master"
    title="master"
    role="button" aria-label="Switch branches or tags" tabindex="0" aria-haspopup="true">
    <span class="octicon octicon-git-branch"></span>
    <i>branch:</i>
    <span class="js-select-button css-truncate-target">master</span>
  </span>

  <div class="select-menu-modal-holder js-menu-content js-navigation-container" data-pjax aria-hidden="true">

    <div class="select-menu-modal">
      <div class="select-menu-header">
        <span class="select-menu-title">Switch branches/tags</span>
        <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
      </div> <!-- /.select-menu-header -->

      <div class="select-menu-filters">
        <div class="select-menu-text-filter">
          <input type="text" aria-label="Filter branches/tags" id="context-commitish-filter-field" class="js-filterable-field js-navigation-enable" placeholder="Filter branches/tags">
        </div>
        <div class="select-menu-tabs">
          <ul>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="branches" class="js-select-menu-tab">Branches</a>
            </li>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="tags" class="js-select-menu-tab">Tags</a>
            </li>
          </ul>
        </div><!-- /.select-menu-tabs -->
      </div><!-- /.select-menu-filters -->

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="branches">

        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


            <div class="select-menu-item js-navigation-item ">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <a href="/bartaz/impress.js/blob/RGSoC/README.md"
                 data-name="RGSoC"
                 data-skip-pjax="true"
                 rel="nofollow"
                 class="js-navigation-open select-menu-item-text css-truncate-target"
                 title="RGSoC">RGSoC</a>
            </div> <!-- /.select-menu-item -->
            <div class="select-menu-item js-navigation-item ">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <a href="/bartaz/impress.js/blob/dev/README.md"
                 data-name="dev"
                 data-skip-pjax="true"
                 rel="nofollow"
                 class="js-navigation-open select-menu-item-text css-truncate-target"
                 title="dev">dev</a>
            </div> <!-- /.select-menu-item -->
            <div class="select-menu-item js-navigation-item ">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <a href="/bartaz/impress.js/blob/gh-pages/README.md"
                 data-name="gh-pages"
                 data-skip-pjax="true"
                 rel="nofollow"
                 class="js-navigation-open select-menu-item-text css-truncate-target"
                 title="gh-pages">gh-pages</a>
            </div> <!-- /.select-menu-item -->
            <div class="select-menu-item js-navigation-item selected">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <a href="/bartaz/impress.js/blob/master/README.md"
                 data-name="master"
                 data-skip-pjax="true"
                 rel="nofollow"
                 class="js-navigation-open select-menu-item-text css-truncate-target"
                 title="master">master</a>
            </div> <!-- /.select-menu-item -->
        </div>

          <div class="select-menu-no-results">Nothing to show</div>
      </div> <!-- /.select-menu-list -->

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="tags">
        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


            <div class="select-menu-item js-navigation-item ">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <a href="/bartaz/impress.js/tree/0.5.3/README.md"
                 data-name="0.5.3"
                 data-skip-pjax="true"
                 rel="nofollow"
                 class="js-navigation-open select-menu-item-text css-truncate-target"
                 title="0.5.3">0.5.3</a>
            </div> <!-- /.select-menu-item -->
            <div class="select-menu-item js-navigation-item ">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <a href="/bartaz/impress.js/tree/0.5.2/README.md"
                 data-name="0.5.2"
                 data-skip-pjax="true"
                 rel="nofollow"
                 class="js-navigation-open select-menu-item-text css-truncate-target"
                 title="0.5.2">0.5.2</a>
            </div> <!-- /.select-menu-item -->
            <div class="select-menu-item js-navigation-item ">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <a href="/bartaz/impress.js/tree/0.5.1/README.md"
                 data-name="0.5.1"
                 data-skip-pjax="true"
                 rel="nofollow"
                 class="js-navigation-open select-menu-item-text css-truncate-target"
                 title="0.5.1">0.5.1</a>
            </div> <!-- /.select-menu-item -->
            <div class="select-menu-item js-navigation-item ">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <a href="/bartaz/impress.js/tree/0.5/README.md"
                 data-name="0.5"
                 data-skip-pjax="true"
                 rel="nofollow"
                 class="js-navigation-open select-menu-item-text css-truncate-target"
                 title="0.5">0.5</a>
            </div> <!-- /.select-menu-item -->
            <div class="select-menu-item js-navigation-item ">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <a href="/bartaz/impress.js/tree/0.4.1/README.md"
                 data-name="0.4.1"
                 data-skip-pjax="true"
                 rel="nofollow"
                 class="js-navigation-open select-menu-item-text css-truncate-target"
                 title="0.4.1">0.4.1</a>
            </div> <!-- /.select-menu-item -->
            <div class="select-menu-item js-navigation-item ">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <a href="/bartaz/impress.js/tree/0.4/README.md"
                 data-name="0.4"
                 data-skip-pjax="true"
                 rel="nofollow"
                 class="js-navigation-open select-menu-item-text css-truncate-target"
                 title="0.4">0.4</a>
            </div> <!-- /.select-menu-item -->
            <div class="select-menu-item js-navigation-item ">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <a href="/bartaz/impress.js/tree/0.3/README.md"
                 data-name="0.3"
                 data-skip-pjax="true"
                 rel="nofollow"
                 class="js-navigation-open select-menu-item-text css-truncate-target"
                 title="0.3">0.3</a>
            </div> <!-- /.select-menu-item -->
            <div class="select-menu-item js-navigation-item ">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <a href="/bartaz/impress.js/tree/0.2/README.md"
                 data-name="0.2"
                 data-skip-pjax="true"
                 rel="nofollow"
                 class="js-navigation-open select-menu-item-text css-truncate-target"
                 title="0.2">0.2</a>
            </div> <!-- /.select-menu-item -->
            <div class="select-menu-item js-navigation-item ">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <a href="/bartaz/impress.js/tree/0.1/README.md"
                 data-name="0.1"
                 data-skip-pjax="true"
                 rel="nofollow"
                 class="js-navigation-open select-menu-item-text css-truncate-target"
                 title="0.1">0.1</a>
            </div> <!-- /.select-menu-item -->
        </div>

        <div class="select-menu-no-results">Nothing to show</div>
      </div> <!-- /.select-menu-list -->

    </div> <!-- /.select-menu-modal -->
  </div> <!-- /.select-menu-modal-holder -->
</div> <!-- /.select-menu -->

  <div class="button-group right">
    <a href="/bartaz/impress.js/find/master"
          class="js-show-file-finder minibutton empty-icon tooltipped tooltipped-s"
          data-pjax
          data-hotkey="t"
          aria-label="Quickly jump between files">
      <span class="octicon octicon-list-unordered"></span>
    </a>
    <button class="js-zeroclipboard minibutton zeroclipboard-button"
          data-clipboard-text="README.md"
          aria-label="Copy to clipboard"
          data-copied-hint="Copied!">
      <span class="octicon octicon-clippy"></span>
    </button>
  </div>

  <div class="breadcrumb">
    <span class='repo-root js-repo-root'><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/bartaz/impress.js" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">impress.js</span></a></span></span><span class="separator"> / </span><strong class="final-path">README.md</strong>
  </div>
</div>


  <div class="commit file-history-tease">
    <div class="file-history-tease-header">
        <img alt="Deshraj Yadav" class="avatar" data-user="2945708" height="24" src="https://avatars3.githubusercontent.com/u/2945708?v=2&amp;s=48" width="24" />
        <span class="author"><a href="/DESHRAJ" rel="contributor">DESHRAJ</a></span>
        <time datetime="2014-08-19T19:46:05Z" is="relative-time">Aug 20, 2014</time>
        <div class="commit-title">
            <a href="/bartaz/impress.js/commit/e36939744ac351dd4643d3b7360213bcce34275f" class="message" data-pjax="true" title="readme file corrected">readme file corrected</a>
        </div>
    </div>

    <div class="participation">
      <p class="quickstat">
        <a href="#blob_contributors_box" rel="facebox">
          <strong>15</strong>
           contributors
        </a>
      </p>
          <a class="avatar-link tooltipped tooltipped-s" aria-label="bartaz" href="/bartaz/impress.js/commits/master/README.md?author=bartaz"><img alt="Bartek Szopka" class="avatar" data-user="83575" height="20" src="https://avatars0.githubusercontent.com/u/83575?v=2&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="exequiel09" href="/bartaz/impress.js/commits/master/README.md?author=exequiel09"><img alt="Exequiel Ceasar Navarrete" class="avatar" data-user="1289472" height="20" src="https://avatars1.githubusercontent.com/u/1289472?v=2&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="medikoo" href="/bartaz/impress.js/commits/master/README.md?author=medikoo"><img alt="Mariusz Nowak" class="avatar" data-user="122434" height="20" src="https://avatars3.githubusercontent.com/u/122434?v=2&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="lioshi" href="/bartaz/impress.js/commits/master/README.md?author=lioshi"><img alt="lioshi" class="avatar" data-user="1125136" height="20" src="https://avatars0.githubusercontent.com/u/1125136?v=2&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="AlecRust" href="/bartaz/impress.js/commits/master/README.md?author=AlecRust"><img alt="Alec Rust" class="avatar" data-user="247634" height="20" src="https://avatars0.githubusercontent.com/u/247634?v=2&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="t3kila" href="/bartaz/impress.js/commits/master/README.md?author=t3kila"><img alt="t3kila" class="avatar" data-user="1520893" height="20" src="https://avatars1.githubusercontent.com/u/1520893?v=2&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="majnun" href="/bartaz/impress.js/commits/master/README.md?author=majnun"><img alt="majnun" class="avatar" data-user="1267096" height="20" src="https://avatars2.githubusercontent.com/u/1267096?v=2&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="richardneville" href="/bartaz/impress.js/commits/master/README.md?author=richardneville"><img alt="Richard Neville" class="avatar" data-user="1315265" height="20" src="https://avatars3.githubusercontent.com/u/1315265?v=2&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="thingsinjars" href="/bartaz/impress.js/commits/master/README.md?author=thingsinjars"><img alt="Simon Madine" class="avatar" data-user="147663" height="20" src="https://avatars2.githubusercontent.com/u/147663?v=2&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="ktagliabue" href="/bartaz/impress.js/commits/master/README.md?author=ktagliabue"><img alt="Kandis Tagliabue" class="avatar" data-user="4111286" height="20" src="https://avatars3.githubusercontent.com/u/4111286?v=2&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="fulljames" href="/bartaz/impress.js/commits/master/README.md?author=fulljames"><img alt="Stephen Fulljames" class="avatar" data-user="793236" height="20" src="https://avatars0.githubusercontent.com/u/793236?v=2&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="DronRathore" href="/bartaz/impress.js/commits/master/README.md?author=DronRathore"><img alt="Dron Rathore" class="avatar" data-user="1112049" height="20" src="https://avatars2.githubusercontent.com/u/1112049?v=2&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="dolanor" href="/bartaz/impress.js/commits/master/README.md?author=dolanor"><img alt="dolanor" class="avatar" data-user="928722" height="20" src="https://avatars1.githubusercontent.com/u/928722?v=2&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="DESHRAJ" href="/bartaz/impress.js/commits/master/README.md?author=DESHRAJ"><img alt="Deshraj Yadav" class="avatar" data-user="2945708" height="20" src="https://avatars1.githubusercontent.com/u/2945708?v=2&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="sylvainw" href="/bartaz/impress.js/commits/master/README.md?author=sylvainw"><img alt="Sylvain Weber" class="avatar" data-user="272723" height="20" src="https://avatars2.githubusercontent.com/u/272723?v=2&amp;s=40" width="20" /></a>


    </div>
    <div id="blob_contributors_box" style="display:none">
      <h2 class="facebox-header">Users who have contributed to this file</h2>
      <ul class="facebox-user-list">
          <li class="facebox-user-list-item">
            <img alt="Bartek Szopka" data-user="83575" height="24" src="https://avatars2.githubusercontent.com/u/83575?v=2&amp;s=48" width="24" />
            <a href="/bartaz">bartaz</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="Exequiel Ceasar Navarrete" data-user="1289472" height="24" src="https://avatars3.githubusercontent.com/u/1289472?v=2&amp;s=48" width="24" />
            <a href="/exequiel09">exequiel09</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="Mariusz Nowak" data-user="122434" height="24" src="https://avatars1.githubusercontent.com/u/122434?v=2&amp;s=48" width="24" />
            <a href="/medikoo">medikoo</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="lioshi" data-user="1125136" height="24" src="https://avatars2.githubusercontent.com/u/1125136?v=2&amp;s=48" width="24" />
            <a href="/lioshi">lioshi</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="Alec Rust" data-user="247634" height="24" src="https://avatars2.githubusercontent.com/u/247634?v=2&amp;s=48" width="24" />
            <a href="/AlecRust">AlecRust</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="t3kila" data-user="1520893" height="24" src="https://avatars3.githubusercontent.com/u/1520893?v=2&amp;s=48" width="24" />
            <a href="/t3kila">t3kila</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="majnun" data-user="1267096" height="24" src="https://avatars0.githubusercontent.com/u/1267096?v=2&amp;s=48" width="24" />
            <a href="/majnun">majnun</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="Richard Neville" data-user="1315265" height="24" src="https://avatars1.githubusercontent.com/u/1315265?v=2&amp;s=48" width="24" />
            <a href="/richardneville">richardneville</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="Simon Madine" data-user="147663" height="24" src="https://avatars0.githubusercontent.com/u/147663?v=2&amp;s=48" width="24" />
            <a href="/thingsinjars">thingsinjars</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="Kandis Tagliabue" data-user="4111286" height="24" src="https://avatars1.githubusercontent.com/u/4111286?v=2&amp;s=48" width="24" />
            <a href="/ktagliabue">ktagliabue</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="Stephen Fulljames" data-user="793236" height="24" src="https://avatars2.githubusercontent.com/u/793236?v=2&amp;s=48" width="24" />
            <a href="/fulljames">fulljames</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="Dron Rathore" data-user="1112049" height="24" src="https://avatars0.githubusercontent.com/u/1112049?v=2&amp;s=48" width="24" />
            <a href="/DronRathore">DronRathore</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="dolanor" data-user="928722" height="24" src="https://avatars3.githubusercontent.com/u/928722?v=2&amp;s=48" width="24" />
            <a href="/dolanor">dolanor</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="Deshraj Yadav" data-user="2945708" height="24" src="https://avatars3.githubusercontent.com/u/2945708?v=2&amp;s=48" width="24" />
            <a href="/DESHRAJ">DESHRAJ</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="Sylvain Weber" data-user="272723" height="24" src="https://avatars0.githubusercontent.com/u/272723?v=2&amp;s=48" width="24" />
            <a href="/sylvainw">sylvainw</a>
          </li>
      </ul>
    </div>
  </div>

<div class="file-box">
  <div class="file">
    <div class="meta clearfix">
      <div class="info file-name">
          <span>304 lines (186 sloc)</span>
          <span class="meta-divider"></span>
        <span>14.139 kb</span>
      </div>
      <div class="actions">
        <div class="button-group">
          <a href="/bartaz/impress.js/raw/master/README.md" class="minibutton " id="raw-url">Raw</a>
            <a href="/bartaz/impress.js/blame/master/README.md" class="minibutton js-update-url-with-hash">Blame</a>
          <a href="/bartaz/impress.js/commits/master/README.md" class="minibutton " rel="nofollow">History</a>
        </div><!-- /.button-group -->

          <a class="octicon-button tooltipped tooltipped-nw"
             href="github-windows://openRepo/https://github.com/bartaz/impress.js?branch=master&amp;filepath=README.md" aria-label="Open this file in GitHub for Windows">
              <span class="octicon octicon-device-desktop"></span>
          </a>

              <a class="octicon-button tooltipped tooltipped-n js-update-url-with-hash"
                 aria-label="Clicking this button will fork this project so you can edit the file"
                 href="/bartaz/impress.js/edit/master/README.md"
                 data-method="post" rel="nofollow"><span class="octicon octicon-pencil"></span></a>

            <a class="octicon-button danger tooltipped tooltipped-s"
               href="/bartaz/impress.js/delete/master/README.md"
               aria-label="Fork this project and delete file"
               data-method="post" data-test-id="delete-blob-file" rel="nofollow">
          <span class="octicon octicon-trashcan"></span>
        </a>
      </div><!-- /.actions -->
    </div>
      <div id="readme" class="blob instapaper_body">
    <article class="markdown-body entry-content" itemprop="mainContentOfPage"><h1>
<a id="user-content-impressjs" class="anchor" href="#impressjs" aria-hidden="true"><span class="octicon octicon-link"></span></a>impress.js</h1>

<p>It's a presentation framework based on the power of CSS3 transforms and 
transitions in modern browsers and inspired by the idea behind prezi.com.</p>

<p><strong>WARNING</strong></p>

<p>impress.js may not help you if you have nothing interesting to say ;)</p>

<h2>
<a id="user-content-how-to-use-it" class="anchor" href="#how-to-use-it" aria-hidden="true"><span class="octicon octicon-link"></span></a>HOW TO USE IT</h2>

<p><a href="http://github.com/bartaz/impress.js/blob/master/index.html">Use the source</a>, Luke ;)</p>

<p>If you have no idea what I mean by that, or you just clicked that link above and got 
very confused by all these strange characters that got displayed on your screen,
it's a sign, that impress.js is not for you.</p>

<p>Sorry.</p>

<p>Fortunately there are some guys on GitHub that got quite excited with the idea of building
editing tool for impress.js. Let's hope they will manage to do it.</p>

<h2>
<a id="user-content-examples-and-other-learning-resources" class="anchor" href="#examples-and-other-learning-resources" aria-hidden="true"><span class="octicon octicon-link"></span></a>EXAMPLES AND OTHER LEARNING RESOURCES</h2>

<h3>
<a id="user-content-official-demo" class="anchor" href="#official-demo" aria-hidden="true"><span class="octicon octicon-link"></span></a>Official demo</h3>

<p><a href="http://bartaz.github.com/impress.js">impress.js demo</a> by <a href="http://twitter.com/bartaz">@bartaz</a></p>

<h3>
<a id="user-content-examples-and-demos" class="anchor" href="#examples-and-demos" aria-hidden="true"><span class="octicon octicon-link"></span></a>Examples and demos</h3>

<p>More examples and demos can be found on <a href="http://github.com/bartaz/impress.js/wiki/Examples-and-demos">Examples and demos wiki page</a>.</p>

<p>Feel free to add your own example presentations (or websites) there.</p>

<h3>
<a id="user-content-other-tutorials-and-learning-resources" class="anchor" href="#other-tutorials-and-learning-resources" aria-hidden="true"><span class="octicon octicon-link"></span></a>Other tutorials and learning resources</h3>

<p>If you want to learn even more there is a <a href="https://github.com/bartaz/impress.js/wiki/impress.js-tutorials-and-other-learning-resources">list of tutorials and other learning resources</a>
on the wiki, too.</p>

<p>There is also a book available about <a href="http://www.packtpub.com/building-impressive-presentations-with-impressjs/book">Building impressive presentations with impress.js</a> by Rakhitha Nimesh Ratnayake.</p>

<h2>
<a id="user-content-want-to-contribute" class="anchor" href="#want-to-contribute" aria-hidden="true"><span class="octicon octicon-link"></span></a>WANT TO CONTRIBUTE?</h2>

<p>If you've found a bug or have a great idea for new feature let me know by <a href="http://github.com/bartaz/impress.js/issues/new">adding your suggestion</a> to <a href="https://github.com/bartaz/impress.js/issues">issues list</a>.</p>

<p>If you have fixed a bug or implemented a feature that you'd like to share, send your pull request against <a href="http://github.com/bartaz/impress.js/tree/dev">dev branch</a>. But remember that I only accept code that fits my vision of impress.js
and my coding standards - so make sure you are open for discussion :)</p>

<h2>
<a id="user-content-about-the-name" class="anchor" href="#about-the-name" aria-hidden="true"><span class="octicon octicon-link"></span></a>ABOUT THE NAME</h2>

<p>impress.js name in <a href="http://twitter.com/skuzniak/status/143627215165333504">courtesy of @skuzniak</a>.</p>

<p>It's an (un)fortunate coincidence that a Open/LibreOffice presentation tool is called Impress ;)</p>

<h2>
<a id="user-content-version-history" class="anchor" href="#version-history" aria-hidden="true"><span class="octicon octicon-link"></span></a>VERSION HISTORY</h2>

<h3>
<a id="user-content-053-browse-zip-tar" class="anchor" href="#053-browse-zip-tar" aria-hidden="true"><span class="octicon octicon-link"></span></a>0.5.3 (<a href="http://github.com/bartaz/impress.js/tree/0.5.3">browse</a>, <a href="http://github.com/bartaz/impress.js/zipball/0.5.3">zip</a>, <a href="http://github.com/bartaz/impress.js/tarball/0.5.3">tar</a>)</h3>

<h4>
<a id="user-content-bugfix-release" class="anchor" href="#bugfix-release" aria-hidden="true"><span class="octicon octicon-link"></span></a>BUGFIX RELEASE</h4>

<p>Version 0.5 introduced events including <code>impress:stepenter</code>, but this event was not triggered properly in some
specific transition types (for example when only scale was changing between steps). It was caused by the fact that
in such cases expected <code>transitionend</code> event was not triggered.</p>

<p>This version fixes this issue. Unfortunately modern <code>transitionend</code> event is no longer used to detect when the
transition has finished, but old school (and more reliable) <code>setTimeout</code> is used.</p>

<h3>
<a id="user-content-052-browse-zip-tar" class="anchor" href="#052-browse-zip-tar" aria-hidden="true"><span class="octicon octicon-link"></span></a>0.5.2 (<a href="http://github.com/bartaz/impress.js/tree/0.5.2">browse</a>, <a href="http://github.com/bartaz/impress.js/zipball/0.5.2">zip</a>, <a href="http://github.com/bartaz/impress.js/tarball/0.5.2">tar</a>)</h3>

<h4>
<a id="user-content-documentation-release" class="anchor" href="#documentation-release" aria-hidden="true"><span class="octicon octicon-link"></span></a>DOCUMENTATION RELEASE</h4>

<p>More descriptive comments added to demo CSS and impress.js source file, so now not only <code>index.html</code> is worth reading ;)</p>

<h3>
<a id="user-content-051-browse-zip-tar" class="anchor" href="#051-browse-zip-tar" aria-hidden="true"><span class="octicon octicon-link"></span></a>0.5.1 (<a href="http://github.com/bartaz/impress.js/tree/0.5.1">browse</a>, <a href="http://github.com/bartaz/impress.js/zipball/0.5.1">zip</a>, <a href="http://github.com/bartaz/impress.js/tarball/0.5.1">tar</a>)</h3>

<h4>
<a id="user-content-bugfix-release-1" class="anchor" href="#bugfix-release-1" aria-hidden="true"><span class="octicon octicon-link"></span></a>BUGFIX RELEASE</h4>

<p>Changes in version 0.5 introduced a bug (#126) that was preventing clicks on links (or any clickable elements) on
currently active step. This release fixes this issue.</p>

<h3>
<a id="user-content-05-browse-zip-tar" class="anchor" href="#05-browse-zip-tar" aria-hidden="true"><span class="octicon octicon-link"></span></a>0.5 (<a href="http://github.com/bartaz/impress.js/tree/0.5">browse</a>, <a href="http://github.com/bartaz/impress.js/zipball/0.5">zip</a>, <a href="http://github.com/bartaz/impress.js/tarball/0.5">tar</a>)</h3>

<h4>
<a id="user-content-changelog" class="anchor" href="#changelog" aria-hidden="true"><span class="octicon octicon-link"></span></a>CHANGELOG</h4>

<ul class="task-list">
<li>API changed, so that <code>impress()</code> function no longer automatically initialize presentation; new method called <code>init</code>
was added to API and it should be used to start the presentation</li>
<li>event <code>impress:init</code> is triggered on root presentation element (<code>#impress</code> by default) when presentation is initialized</li>
<li>new CSS classes were added: <code>impress-disabled</code> is added to body element by the impress.js script and it's changed to 
<code>impress-enabled</code> when <code>init()</code> function is called</li>
<li>events added when step is entered and left - custom <code>impress:stepenter</code> and <code>impress:stepleave</code> events are triggered
on step elements and can be handled like any other DOM events (with <code>addEventListener</code>)</li>
<li>additional <code>past</code>, <code>present</code> and <code>future</code> classes are added to step elements

<ul class="task-list">
<li>
<code>future</code> class appears on steps that were not yet visited</li>
<li>
<code>present</code> class appears on currently visible step - it's different from <code>active</code> class as <code>present</code> class
is added when transition finishes (step is entered)</li>
<li>
<code>past</code> class is added to already visited steps (when the step is left)</li>
</ul>
</li>
<li>and good news, <code>goto()</code> API method is back! it seems that <code>goto</code> <strong>was</strong> a future reserved word but isn't anymore,
so we can use this short and pretty name instead of camelCassy <code>stepTo</code> - and yes, that means API changed again...</li>
<li>additionally <code>goto()</code> method now supports new types of parameters:

<ul class="task-list">
<li>you can give it a number of step you want to go to: <code>impress().goto(7)</code>
</li>
<li>or its id: <code>impress().goto("the-best-slide-ever")</code>
</li>
<li>of course DOM element is still acceptable: <code>impress().goto( document.getElementById("overview") )</code>
</li>
</ul>
</li>
<li>and if it's not enough, <code>goto()</code> also accepts second parameter to define the transition duration in ms, for example
<code>impress().goto("make-it-quick", 300)</code> or <code>impress().goto("now", 0)</code>
</li>
</ul>

<h4>
<a id="user-content-upgrading-from-previous-versions" class="anchor" href="#upgrading-from-previous-versions" aria-hidden="true"><span class="octicon octicon-link"></span></a>UPGRADING FROM PREVIOUS VERSIONS</h4>

<p>In current version calling <code>impress()</code> doesn't automatically initialize the presentation. You need to call <code>init()</code>
function from the API. So in a place were you called <code>impress()</code> to initialize impress.js simply change this call
to <code>impress().init()</code>.</p>

<p>Version 0.4 changed <code>goto</code> API method into <code>stepTo</code>. It turned out that <code>goto</code> is not a reserved word anymore, so it
can be used in JavaScript. That's why version 0.5 brings it back and removes <code>stepTo</code>.</p>

<p>So if you have been using version 0.4 and have any reference to <code>stepTo</code> API method make sure to change it to <code>goto</code>.</p>

<h3>
<a id="user-content-041-browse-zip-tar" class="anchor" href="#041-browse-zip-tar" aria-hidden="true"><span class="octicon octicon-link"></span></a>0.4.1 (<a href="http://github.com/bartaz/impress.js/tree/0.4.1">browse</a>, <a href="http://github.com/bartaz/impress.js/zipball/0.4.1">zip</a>, <a href="http://github.com/bartaz/impress.js/tarball/0.4.1">tar</a>)</h3>

<h4>
<a id="user-content-bugfix-release-2" class="anchor" href="#bugfix-release-2" aria-hidden="true"><span class="octicon octicon-link"></span></a>BUGFIX RELEASE</h4>

<p>Changes is version 0.4 introduced a bug causing JavaScript errors being thrown all over the place in fallback mode.
This release fixes this issue.</p>

<p>It also adds a flag <code>impress.supported</code> that can be used in JavaScript to check if impress.js is supported in the browser.</p>

<h3>
<a id="user-content-04-browse-zip-tar" class="anchor" href="#04-browse-zip-tar" aria-hidden="true"><span class="octicon octicon-link"></span></a>0.4 (<a href="http://github.com/bartaz/impress.js/tree/0.4">browse</a>, <a href="http://github.com/bartaz/impress.js/zipball/0.4">zip</a>, <a href="http://github.com/bartaz/impress.js/tarball/0.4">tar</a>)</h3>

<h4>
<a id="user-content-changelog-1" class="anchor" href="#changelog-1" aria-hidden="true"><span class="octicon octicon-link"></span></a>CHANGELOG</h4>

<ul class="task-list">
<li>configuration options on <code>#impress</code> element: <code>data-perspective</code> (in px, defaults so 1000),
<code>data-transition-duration</code> (in ms, defaults to 1000)</li>
<li>automatic scaling to fit window size, with configuration options:  <code>data-width</code> (in px, defaults to 1024),
<code>data-height</code> (in px, defaults to 768), <code>max-scale</code> (defaults to 1), <code>min-scale</code> (defaults to 0)</li>
<li>
<code>goto</code> API function was renamed to <code>stepTo</code> because <code>goto</code> is a future reserved work in JavaScript,
so <strong>please make sure to update your code</strong>
</li>
<li>fallback <code>impress-not-supported</code> class is now set on <code>body</code> element instead of <code>#impress</code> element and it's
replaced with <code>impress-supported</code> when browser supports all required features</li>
<li>classes <code>step-ID</code> used to indicate progress of the presentation are now renamed to <code>impress-on-ID</code> and are
set on <code>body</code> element, so <strong>please make sure to update your code</strong>
</li>
<li>basic validation of configuration options</li>
<li>couple of typos and bugs fixed</li>
<li>favicon added ;)</li>
</ul>

<h4>
<a id="user-content-upgrading-from-previous-versions-1" class="anchor" href="#upgrading-from-previous-versions-1" aria-hidden="true"><span class="octicon octicon-link"></span></a>UPGRADING FROM PREVIOUS VERSIONS</h4>

<p>If in your custom JavaScript code you were using <code>goto()</code> function from impress.js API make sure to change it
to <code>stepTo()</code>.</p>

<p>If in your CSS you were using classes based on currently active step with <code>step-</code> prefix, such as <code>step-bored</code>
(where <code>bored</code> is the id of the step element) make sure to change it to <code>impress-on-</code> prefix
(for example <code>impress-on-bored</code>). Also in previous versions these classes were assigned to <code>#impress</code> element
and now they are added to <code>body</code> element, so if your CSS code depends on this, it also should be updated.</p>

<p>Same happened to <code>impress-not-supported</code> class name - it was moved from <code>#impress</code> element to <code>body</code>, so update
your CSS if it's needed.</p>

<h4>
<a id="user-content-note-on-blackberry-playbook" class="anchor" href="#note-on-blackberry-playbook" aria-hidden="true"><span class="octicon octicon-link"></span></a>NOTE ON BLACKBERRY PLAYBOOK</h4>

<p>Changes and fixes added in this version have broken the experience on Blackberry Playbook with OS in version 1.0.
It happened due to a bug in the Playbook browser in this version. Fortunately in version 2.0 of Playbook OS this
bug was fixed and impress.js works fine.</p>

<p>So currently impress.js work only on Blackberry Playbook with latest OS. Fortunately, <a href="http://twitter.com/n_adam_stanley/status/178188611827679233">it seems that most of the
users</a> <a href="http://twitter.com/brcewane/status/178230406196379648">are quite quick with updating their devices</a></p>

<h3>
<a id="user-content-03-browse-zip-tar" class="anchor" href="#03-browse-zip-tar" aria-hidden="true"><span class="octicon octicon-link"></span></a>0.3 (<a href="http://github.com/bartaz/impress.js/tree/0.3">browse</a>, <a href="http://github.com/bartaz/impress.js/zipball/0.3">zip</a>, <a href="http://github.com/bartaz/impress.js/tarball/0.3">tar</a>)</h3>

<h4>
<a id="user-content-changelog-2" class="anchor" href="#changelog-2" aria-hidden="true"><span class="octicon octicon-link"></span></a>CHANGELOG</h4>

<ul class="task-list">
<li>minor CSS 3D fixes</li>
<li>basic API to control the presentation flow from JavaScript</li>
<li>touch event support</li>
<li>basic support for iPad (iOS 5 and iOS 4 with polyfills) and Blackberry Playbook</li>
</ul>

<h4>
<a id="user-content-upgrading-from-previous-versions-2" class="anchor" href="#upgrading-from-previous-versions-2" aria-hidden="true"><span class="octicon octicon-link"></span></a>UPGRADING FROM PREVIOUS VERSIONS</h4>

<p>Because API was introduced the way impress.js script is initialized was changed a bit. You not only have to include
<code>impress.js</code> script file, but also call <code>impress()</code> function.</p>

<p>See the source of <code>index.html</code> for example and more details.</p>

<h3>
<a id="user-content-02-browse-zip-tar" class="anchor" href="#02-browse-zip-tar" aria-hidden="true"><span class="octicon octicon-link"></span></a>0.2 (<a href="http://github.com/bartaz/impress.js/tree/0.2">browse</a>, <a href="http://github.com/bartaz/impress.js/zipball/0.2">zip</a>, <a href="http://github.com/bartaz/impress.js/tarball/0.2">tar</a>)</h3>

<ul class="task-list">
<li>tutorial/documentation added to <code>index.html</code> source file</li>
<li>being even more strict with strict mode</li>
<li>code clean-up</li>
<li>couple of small bug-fixes</li>
</ul>

<h3>
<a id="user-content-01-browse-zip-tar" class="anchor" href="#01-browse-zip-tar" aria-hidden="true"><span class="octicon octicon-link"></span></a>0.1 (<a href="http://github.com/bartaz/impress.js/tree/0.1">browse</a>, <a href="http://github.com/bartaz/impress.js/zipball/0.1">zip</a>, <a href="http://github.com/bartaz/impress.js/tarball/0.1">tar</a>)</h3>

<p>First release.</p>

<p>Contains basic functionality for step placement and transitions between them
with simple fallback for non-supporting browsers.</p>

<h2>
<a id="user-content-browser-support" class="anchor" href="#browser-support" aria-hidden="true"><span class="octicon octicon-link"></span></a>BROWSER SUPPORT</h2>

<h3>
<a id="user-content-tldr" class="anchor" href="#tldr" aria-hidden="true"><span class="octicon octicon-link"></span></a>TL;DR;</h3>

<p>Currently impress.js works fine in latest Chrome/Chromium browser, Safari 5.1 and Firefox 10.
With addition of some HTML5 polyfills (see below for details) it should work in Internet Explorer 10
(currently available as Developers Preview).
It doesn't work in Opera, as it doesn't support CSS 3D transforms.</p>

<p>As a presentation tool it was not developed with mobile browsers in mind, but some tablets are good
enough to run it, so it should work quite well on iPad (iOS 5, or iOS 4 with HTML5 polyfills) and 
Blackberry Playbook.</p>

<h3>
<a id="user-content-still-interested-read-more" class="anchor" href="#still-interested-read-more" aria-hidden="true"><span class="octicon octicon-link"></span></a>Still interested? Read more...</h3>

<p>Additionally for the animations to run smoothly it's required to have hardware
acceleration support in your browser. This depends on the browser, your operating
system and even kind of graphic hardware you have in your machine.</p>

<p>For browsers not supporting CSS3 3D transforms impress.js adds <code>impress-not-supported</code>
class on <code>#impress</code> element, so fallback styles can be applied to make all the content accessible.</p>

<h3>
<a id="user-content-even-more-explanation-and-technical-stuff" class="anchor" href="#even-more-explanation-and-technical-stuff" aria-hidden="true"><span class="octicon octicon-link"></span></a>Even more explanation and technical stuff</h3>

<p>Let's put this straight -- wide browser support was (and is) not on top of my priority list for
impress.js. It's built on top of fresh technologies that just start to appear in the browsers
and I'd like to rather look forward and develop for the future than being slowed down by the past.</p>

<p>But it's not "hard-coded" for any particular browser or engine. If any browser in future will
support features required to run impress.js, it will just begin to work there without changes in
the code.</p>

<p>From technical point of view all the positioning of presentation elements in 3D requires CSS 3D
transforms support. Transitions between presentation steps are based on CSS transitions.
So these two features are required by impress.js to display presentation correctly.</p>

<p>Unfortunately the support for CSS 3D transforms and transitions is not enough for animations to
run smoothly. If the browser doesn't support hardware acceleration or the graphic card is not 
good enough the transitions will be laggy.</p>

<p>Additionally the code of impress.js relies on APIs proposed in HTML5 specification, including
<code>classList</code> and <code>dataset</code> APIs. If they are not available in the browser, impress.js will not work.</p>

<p>Fortunately, as these are JavaScript APIs there are polyfill libraries that patch older browsers
with these APIs.</p>

<p>For example IE10 is said to support CSS 3D transforms and transitions, but it doesn't have <code>classList</code>
nor <code>dataset</code> APIs implemented at the moment. So including polyfill libraries <em>should</em> help IE10
with running impress.js.</p>

<h3>
<a id="user-content-and-few-more-details-about-mobile-support" class="anchor" href="#and-few-more-details-about-mobile-support" aria-hidden="true"><span class="octicon octicon-link"></span></a>And few more details about mobile support</h3>

<p>Mobile browsers are currently not supported. Even Android browsers that support CSS 3D transforms are
forced into fallback view at this point.</p>

<p>Fortunately some tablets seem to have good enough hardware support and browsers to handle it.
Currently impress.js presentations should work on iPad and Blackberry Playbook.</p>

<p>In theory iPhone should also be able to run it (as it runs the same software as iPad), but I haven't
found a good way to handle its small screen.</p>

<p>Also note that iOS supports <code>classList</code> and <code>dataset</code> APIs starting with version 5, so iOS 4.X and older
requires polyfills to work.</p>

<h2>
<a id="user-content-license" class="anchor" href="#license" aria-hidden="true"><span class="octicon octicon-link"></span></a>LICENSE</h2>

<p>Copyright 2011-2012 Bartek Szopka</p>

<p>Released under the MIT and GPL (version 2 or later) Licenses.</p>
</article>
  </div>

  </div>
</div>

<a href="#jump-to-line" rel="facebox[.linejump]" data-hotkey="l" style="display:none">Jump to Line</a>
<div id="jump-to-line" style="display:none">
  <form accept-charset="UTF-8" class="js-jump-to-line-form">
    <input class="linejump-input js-jump-to-line-field" type="text" placeholder="Jump to line&hellip;" autofocus>
    <button type="submit" class="button">Go</button>
  </form>
</div>

        </div>

      </div><!-- /.repo-container -->
      <div class="modal-backdrop"></div>
    </div><!-- /.container -->
  </div><!-- /.site -->


    </div><!-- /.wrapper -->

      <div class="container">
  <div class="site-footer" role="contentinfo">
    <ul class="site-footer-links right">
      <li><a href="https://status.github.com/">Status</a></li>
      <li><a href="https://developer.github.com">API</a></li>
      <li><a href="http://training.github.com">Training</a></li>
      <li><a href="http://shop.github.com">Shop</a></li>
      <li><a href="/blog">Blog</a></li>
      <li><a href="/about">About</a></li>

    </ul>

    <a href="/" aria-label="Homepage">
      <span class="mega-octicon octicon-mark-github" title="GitHub"></span>
    </a>

    <ul class="site-footer-links">
      <li>&copy; 2014 <span title="0.04812s from github-fe120-cp1-prd.iad.github.net">GitHub</span>, Inc.</li>
        <li><a href="/site/terms">Terms</a></li>
        <li><a href="/site/privacy">Privacy</a></li>
        <li><a href="/security">Security</a></li>
        <li><a href="/contact">Contact</a></li>
    </ul>
  </div><!-- /.site-footer -->
</div><!-- /.container -->


    <div class="fullscreen-overlay js-fullscreen-overlay" id="fullscreen_overlay">
  <div class="fullscreen-container js-suggester-container">
    <div class="textarea-wrap">
      <textarea name="fullscreen-contents" id="fullscreen-contents" class="fullscreen-contents js-fullscreen-contents js-suggester-field" placeholder=""></textarea>
    </div>
  </div>
  <div class="fullscreen-sidebar">
    <a href="#" class="exit-fullscreen js-exit-fullscreen tooltipped tooltipped-w" aria-label="Exit Zen Mode">
      <span class="mega-octicon octicon-screen-normal"></span>
    </a>
    <a href="#" class="theme-switcher js-theme-switcher tooltipped tooltipped-w"
      aria-label="Switch themes">
      <span class="octicon octicon-color-mode"></span>
    </a>
  </div>
</div>



    <div id="ajax-error-message" class="flash flash-error">
      <span class="octicon octicon-alert"></span>
      <a href="#" class="octicon octicon-x flash-close js-ajax-error-dismiss" aria-label="Dismiss error"></a>
      Something went wrong with that request. Please try again.
    </div>


      <script crossorigin="anonymous" src="https://assets-cdn.github.com/assets/frameworks-fe1dc1d9b25d6a0cda010576a3c4be01906c9fd2ac07462042e5fceda326d50c.js" type="text/javascript"></script>
      <script async="async" crossorigin="anonymous" src="https://assets-cdn.github.com/assets/github-daa97aa87d6dd606aba4edb74b70aa2d9f018d4c6298a212a7851ecfcac95d00.js" type="text/javascript"></script>
      
      
  </body>
</html>

