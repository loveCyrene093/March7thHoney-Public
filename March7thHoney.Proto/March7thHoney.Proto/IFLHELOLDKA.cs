using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IFLHELOLDKA : IMessage<IFLHELOLDKA>, IMessage, IEquatable<IFLHELOLDKA>, IDeepCloneable<IFLHELOLDKA>, IBufferMessage
{
	private static readonly MessageParser<IFLHELOLDKA> _parser = new MessageParser<IFLHELOLDKA>(() => new IFLHELOLDKA());

	private UnknownFieldSet _unknownFields;

	public const int JKMLCEJCBLMFieldNumber = 2;

	private ILLBNKFBNBP jKMLCEJCBLM_;

	public const int HCHPDMNGIBNFieldNumber = 9;

	private bool hCHPDMNGIBN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IFLHELOLDKA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IFLHELOLDKAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILLBNKFBNBP JKMLCEJCBLM
	{
		get
		{
			return jKMLCEJCBLM_;
		}
		set
		{
			jKMLCEJCBLM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HCHPDMNGIBN
	{
		get
		{
			return hCHPDMNGIBN_;
		}
		set
		{
			hCHPDMNGIBN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFLHELOLDKA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFLHELOLDKA(IFLHELOLDKA other)
		: this()
	{
		jKMLCEJCBLM_ = ((other.jKMLCEJCBLM_ != null) ? other.jKMLCEJCBLM_.Clone() : null);
		hCHPDMNGIBN_ = other.hCHPDMNGIBN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFLHELOLDKA Clone()
	{
		return new IFLHELOLDKA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IFLHELOLDKA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IFLHELOLDKA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JKMLCEJCBLM, other.JKMLCEJCBLM))
		{
			return false;
		}
		if (HCHPDMNGIBN != other.HCHPDMNGIBN)
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
		if (jKMLCEJCBLM_ != null)
		{
			num ^= JKMLCEJCBLM.GetHashCode();
		}
		if (HCHPDMNGIBN)
		{
			num ^= HCHPDMNGIBN.GetHashCode();
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
		if (jKMLCEJCBLM_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(JKMLCEJCBLM);
		}
		if (HCHPDMNGIBN)
		{
			output.WriteRawTag(72);
			output.WriteBool(HCHPDMNGIBN);
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
		if (jKMLCEJCBLM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JKMLCEJCBLM);
		}
		if (HCHPDMNGIBN)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IFLHELOLDKA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jKMLCEJCBLM_ != null)
		{
			if (jKMLCEJCBLM_ == null)
			{
				JKMLCEJCBLM = new ILLBNKFBNBP();
			}
			JKMLCEJCBLM.MergeFrom(other.JKMLCEJCBLM);
		}
		if (other.HCHPDMNGIBN)
		{
			HCHPDMNGIBN = other.HCHPDMNGIBN;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
				if (jKMLCEJCBLM_ == null)
				{
					JKMLCEJCBLM = new ILLBNKFBNBP();
				}
				input.ReadMessage(JKMLCEJCBLM);
				break;
			case 72u:
				HCHPDMNGIBN = input.ReadBool();
				break;
			}
		}
	}
}
