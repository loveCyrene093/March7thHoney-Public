using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IPBBNKFEEBJ : IMessage<IPBBNKFEEBJ>, IMessage, IEquatable<IPBBNKFEEBJ>, IDeepCloneable<IPBBNKFEEBJ>, IBufferMessage
{
	private static readonly MessageParser<IPBBNKFEEBJ> _parser = new MessageParser<IPBBNKFEEBJ>(() => new IPBBNKFEEBJ());

	private UnknownFieldSet _unknownFields;

	public const int CGDOBAOAHMBFieldNumber = 3;

	private string cGDOBAOAHMB_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IPBBNKFEEBJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IPBBNKFEEBJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CGDOBAOAHMB
	{
		get
		{
			return cGDOBAOAHMB_;
		}
		set
		{
			cGDOBAOAHMB_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPBBNKFEEBJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPBBNKFEEBJ(IPBBNKFEEBJ other)
		: this()
	{
		cGDOBAOAHMB_ = other.cGDOBAOAHMB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPBBNKFEEBJ Clone()
	{
		return new IPBBNKFEEBJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IPBBNKFEEBJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IPBBNKFEEBJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CGDOBAOAHMB != other.CGDOBAOAHMB)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (CGDOBAOAHMB.Length != 0)
		{
			num ^= CGDOBAOAHMB.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (CGDOBAOAHMB.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(CGDOBAOAHMB);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (CGDOBAOAHMB.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CGDOBAOAHMB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IPBBNKFEEBJ other)
	{
		if (other != null)
		{
			if (other.CGDOBAOAHMB.Length != 0)
			{
				CGDOBAOAHMB = other.CGDOBAOAHMB;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				CGDOBAOAHMB = input.ReadString();
			}
		}
	}
}
