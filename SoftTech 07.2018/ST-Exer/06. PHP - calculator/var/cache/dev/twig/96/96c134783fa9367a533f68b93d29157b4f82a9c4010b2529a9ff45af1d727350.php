<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_d496044effa4cc39ce51801babe801f9942ccc5fec27a124c696ada197249fa7 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_7131014038adf8ad87bc29240c7c4e0f82860131a96f5b5771b6b71c817ed403 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_7131014038adf8ad87bc29240c7c4e0f82860131a96f5b5771b6b71c817ed403->enter($__internal_7131014038adf8ad87bc29240c7c4e0f82860131a96f5b5771b6b71c817ed403_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $__internal_b6d09d863cfb3afa8a07c9ed165cd6888ce1ad4fcfd5c7f9600b5f6e968ebd47 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b6d09d863cfb3afa8a07c9ed165cd6888ce1ad4fcfd5c7f9600b5f6e968ebd47->enter($__internal_b6d09d863cfb3afa8a07c9ed165cd6888ce1ad4fcfd5c7f9600b5f6e968ebd47_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_7131014038adf8ad87bc29240c7c4e0f82860131a96f5b5771b6b71c817ed403->leave($__internal_7131014038adf8ad87bc29240c7c4e0f82860131a96f5b5771b6b71c817ed403_prof);

        
        $__internal_b6d09d863cfb3afa8a07c9ed165cd6888ce1ad4fcfd5c7f9600b5f6e968ebd47->leave($__internal_b6d09d863cfb3afa8a07c9ed165cd6888ce1ad4fcfd5c7f9600b5f6e968ebd47_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_7a355ce58757e42e636cee5d78fe10d5adc697bd3fdcb7623e05fd5f22e687fc = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_7a355ce58757e42e636cee5d78fe10d5adc697bd3fdcb7623e05fd5f22e687fc->enter($__internal_7a355ce58757e42e636cee5d78fe10d5adc697bd3fdcb7623e05fd5f22e687fc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_473e48bcca52db1cacc37a6e226b6633c8a3f2f10d009ea5277acc9aeed98147 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_473e48bcca52db1cacc37a6e226b6633c8a3f2f10d009ea5277acc9aeed98147->enter($__internal_473e48bcca52db1cacc37a6e226b6633c8a3f2f10d009ea5277acc9aeed98147_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_473e48bcca52db1cacc37a6e226b6633c8a3f2f10d009ea5277acc9aeed98147->leave($__internal_473e48bcca52db1cacc37a6e226b6633c8a3f2f10d009ea5277acc9aeed98147_prof);

        
        $__internal_7a355ce58757e42e636cee5d78fe10d5adc697bd3fdcb7623e05fd5f22e687fc->leave($__internal_7a355ce58757e42e636cee5d78fe10d5adc697bd3fdcb7623e05fd5f22e687fc_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_bfcbf83665d04b1ed8bd154aafb522d64128359ff0b707466de9cb3416d823a7 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_bfcbf83665d04b1ed8bd154aafb522d64128359ff0b707466de9cb3416d823a7->enter($__internal_bfcbf83665d04b1ed8bd154aafb522d64128359ff0b707466de9cb3416d823a7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_999c2b576c1492fc618636d54b5c5f1ed5c05e11114f3d44c4ae4881d8806f8d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_999c2b576c1492fc618636d54b5c5f1ed5c05e11114f3d44c4ae4881d8806f8d->enter($__internal_999c2b576c1492fc618636d54b5c5f1ed5c05e11114f3d44c4ae4881d8806f8d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_999c2b576c1492fc618636d54b5c5f1ed5c05e11114f3d44c4ae4881d8806f8d->leave($__internal_999c2b576c1492fc618636d54b5c5f1ed5c05e11114f3d44c4ae4881d8806f8d_prof);

        
        $__internal_bfcbf83665d04b1ed8bd154aafb522d64128359ff0b707466de9cb3416d823a7->leave($__internal_bfcbf83665d04b1ed8bd154aafb522d64128359ff0b707466de9cb3416d823a7_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_20f67beb05b7247fec5866e277db2cc35d1162c693916197b5da00bec6d51676 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_20f67beb05b7247fec5866e277db2cc35d1162c693916197b5da00bec6d51676->enter($__internal_20f67beb05b7247fec5866e277db2cc35d1162c693916197b5da00bec6d51676_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_f6cd3fb633fb5d50758a434c038b86b5bd58539dfa181f0a94bb603c0a7d4027 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f6cd3fb633fb5d50758a434c038b86b5bd58539dfa181f0a94bb603c0a7d4027->enter($__internal_f6cd3fb633fb5d50758a434c038b86b5bd58539dfa181f0a94bb603c0a7d4027_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_f6cd3fb633fb5d50758a434c038b86b5bd58539dfa181f0a94bb603c0a7d4027->leave($__internal_f6cd3fb633fb5d50758a434c038b86b5bd58539dfa181f0a94bb603c0a7d4027_prof);

        
        $__internal_20f67beb05b7247fec5866e277db2cc35d1162c693916197b5da00bec6d51676->leave($__internal_20f67beb05b7247fec5866e277db2cc35d1162c693916197b5da00bec6d51676_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  94 => 13,  85 => 12,  71 => 7,  68 => 6,  59 => 5,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
", "@WebProfiler/Collector/router.html.twig", "C:\\xampp\\htdocs\\MyProjects\\PHP-Calculator\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\router.html.twig");
    }
}
