using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BAFPNCPHNFF : IMessage<BAFPNCPHNFF>, IMessage, IEquatable<BAFPNCPHNFF>, IDeepCloneable<BAFPNCPHNFF>, IBufferMessage
{
	private static readonly MessageParser<BAFPNCPHNFF> _parser = new MessageParser<BAFPNCPHNFF>(() => new BAFPNCPHNFF());

	private UnknownFieldSet _unknownFields;

	public const int CCBOELPGMIJFieldNumber = 2;

	private uint cCBOELPGMIJ_;

	public const int EGIPJBJOHLEFieldNumber = 11;

	private bool eGIPJBJOHLE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BAFPNCPHNFF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BAFPNCPHNFFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CCBOELPGMIJ
	{
		get
		{
			return cCBOELPGMIJ_;
		}
		set
		{
			cCBOELPGMIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EGIPJBJOHLE
	{
		get
		{
			return eGIPJBJOHLE_;
		}
		set
		{
			eGIPJBJOHLE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAFPNCPHNFF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAFPNCPHNFF(BAFPNCPHNFF other)
		: this()
	{
		cCBOELPGMIJ_ = other.cCBOELPGMIJ_;
		eGIPJBJOHLE_ = other.eGIPJBJOHLE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAFPNCPHNFF Clone()
	{
		return new BAFPNCPHNFF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BAFPNCPHNFF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BAFPNCPHNFF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CCBOELPGMIJ != other.CCBOELPGMIJ)
		{
			return false;
		}
		if (EGIPJBJOHLE != other.EGIPJBJOHLE)
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
		if (CCBOELPGMIJ != 0)
		{
			num ^= CCBOELPGMIJ.GetHashCode();
		}
		if (EGIPJBJOHLE)
		{
			num ^= EGIPJBJOHLE.GetHashCode();
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
		if (CCBOELPGMIJ != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CCBOELPGMIJ);
		}
		if (EGIPJBJOHLE)
		{
			output.WriteRawTag(88);
			output.WriteBool(EGIPJBJOHLE);
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
		if (CCBOELPGMIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CCBOELPGMIJ);
		}
		if (EGIPJBJOHLE)
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
	public void MergeFrom(BAFPNCPHNFF other)
	{
		if (other != null)
		{
			if (other.CCBOELPGMIJ != 0)
			{
				CCBOELPGMIJ = other.CCBOELPGMIJ;
			}
			if (other.EGIPJBJOHLE)
			{
				EGIPJBJOHLE = other.EGIPJBJOHLE;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
				CCBOELPGMIJ = input.ReadUInt32();
				break;
			case 88u:
				EGIPJBJOHLE = input.ReadBool();
				break;
			}
		}
	}
}
