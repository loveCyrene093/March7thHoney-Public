using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DIBJGAKOCLO : IMessage<DIBJGAKOCLO>, IMessage, IEquatable<DIBJGAKOCLO>, IDeepCloneable<DIBJGAKOCLO>, IBufferMessage
{
	private static readonly MessageParser<DIBJGAKOCLO> _parser = new MessageParser<DIBJGAKOCLO>(() => new DIBJGAKOCLO());

	private UnknownFieldSet _unknownFields;

	public const int AffixIdFieldNumber = 4;

	private uint affixId_;

	public const int JJPCLOIMAKBFieldNumber = 15;

	private bool jJPCLOIMAKB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DIBJGAKOCLO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DIBJGAKOCLOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AffixId
	{
		get
		{
			return affixId_;
		}
		set
		{
			affixId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JJPCLOIMAKB
	{
		get
		{
			return jJPCLOIMAKB_;
		}
		set
		{
			jJPCLOIMAKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DIBJGAKOCLO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DIBJGAKOCLO(DIBJGAKOCLO other)
		: this()
	{
		affixId_ = other.affixId_;
		jJPCLOIMAKB_ = other.jJPCLOIMAKB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DIBJGAKOCLO Clone()
	{
		return new DIBJGAKOCLO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DIBJGAKOCLO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DIBJGAKOCLO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AffixId != other.AffixId)
		{
			return false;
		}
		if (JJPCLOIMAKB != other.JJPCLOIMAKB)
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
		if (AffixId != 0)
		{
			num ^= AffixId.GetHashCode();
		}
		if (JJPCLOIMAKB)
		{
			num ^= JJPCLOIMAKB.GetHashCode();
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
		if (AffixId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AffixId);
		}
		if (JJPCLOIMAKB)
		{
			output.WriteRawTag(120);
			output.WriteBool(JJPCLOIMAKB);
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
		if (AffixId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AffixId);
		}
		if (JJPCLOIMAKB)
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
	public void MergeFrom(DIBJGAKOCLO other)
	{
		if (other != null)
		{
			if (other.AffixId != 0)
			{
				AffixId = other.AffixId;
			}
			if (other.JJPCLOIMAKB)
			{
				JJPCLOIMAKB = other.JJPCLOIMAKB;
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
			case 32u:
				AffixId = input.ReadUInt32();
				break;
			case 120u:
				JJPCLOIMAKB = input.ReadBool();
				break;
			}
		}
	}
}
