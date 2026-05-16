using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FKMKIGFJODF : IMessage<FKMKIGFJODF>, IMessage, IEquatable<FKMKIGFJODF>, IDeepCloneable<FKMKIGFJODF>, IBufferMessage
{
	private static readonly MessageParser<FKMKIGFJODF> _parser = new MessageParser<FKMKIGFJODF>(() => new FKMKIGFJODF());

	private UnknownFieldSet _unknownFields;

	public const int PEGELNHGMJAFieldNumber = 7;

	private uint pEGELNHGMJA_;

	public const int GKFEGIBGEGIFieldNumber = 9;

	private uint gKFEGIBGEGI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FKMKIGFJODF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FKMKIGFJODFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PEGELNHGMJA
	{
		get
		{
			return pEGELNHGMJA_;
		}
		set
		{
			pEGELNHGMJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GKFEGIBGEGI
	{
		get
		{
			return gKFEGIBGEGI_;
		}
		set
		{
			gKFEGIBGEGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FKMKIGFJODF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FKMKIGFJODF(FKMKIGFJODF other)
		: this()
	{
		pEGELNHGMJA_ = other.pEGELNHGMJA_;
		gKFEGIBGEGI_ = other.gKFEGIBGEGI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FKMKIGFJODF Clone()
	{
		return new FKMKIGFJODF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FKMKIGFJODF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FKMKIGFJODF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PEGELNHGMJA != other.PEGELNHGMJA)
		{
			return false;
		}
		if (GKFEGIBGEGI != other.GKFEGIBGEGI)
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
		if (PEGELNHGMJA != 0)
		{
			num ^= PEGELNHGMJA.GetHashCode();
		}
		if (GKFEGIBGEGI != 0)
		{
			num ^= GKFEGIBGEGI.GetHashCode();
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
		if (PEGELNHGMJA != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(PEGELNHGMJA);
		}
		if (GKFEGIBGEGI != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(GKFEGIBGEGI);
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
		if (PEGELNHGMJA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PEGELNHGMJA);
		}
		if (GKFEGIBGEGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GKFEGIBGEGI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FKMKIGFJODF other)
	{
		if (other != null)
		{
			if (other.PEGELNHGMJA != 0)
			{
				PEGELNHGMJA = other.PEGELNHGMJA;
			}
			if (other.GKFEGIBGEGI != 0)
			{
				GKFEGIBGEGI = other.GKFEGIBGEGI;
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
			case 56u:
				PEGELNHGMJA = input.ReadUInt32();
				break;
			case 72u:
				GKFEGIBGEGI = input.ReadUInt32();
				break;
			}
		}
	}
}
