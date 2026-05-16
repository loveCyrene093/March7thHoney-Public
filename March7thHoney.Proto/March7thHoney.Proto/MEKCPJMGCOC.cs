using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MEKCPJMGCOC : IMessage<MEKCPJMGCOC>, IMessage, IEquatable<MEKCPJMGCOC>, IDeepCloneable<MEKCPJMGCOC>, IBufferMessage
{
	private static readonly MessageParser<MEKCPJMGCOC> _parser = new MessageParser<MEKCPJMGCOC>(() => new MEKCPJMGCOC());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 2;

	private uint groupId_;

	public const int NHGHEBJCCCOFieldNumber = 4;

	private uint nHGHEBJCCCO_;

	public const int COOOFFKIDMCFieldNumber = 5;

	private uint cOOOFFKIDMC_;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int JCCOOAEPGEDFieldNumber = 12;

	private uint jCCOOAEPGED_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MEKCPJMGCOC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MEKCPJMGCOCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NHGHEBJCCCO
	{
		get
		{
			return nHGHEBJCCCO_;
		}
		set
		{
			nHGHEBJCCCO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint COOOFFKIDMC
	{
		get
		{
			return cOOOFFKIDMC_;
		}
		set
		{
			cOOOFFKIDMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JCCOOAEPGED
	{
		get
		{
			return jCCOOAEPGED_;
		}
		set
		{
			jCCOOAEPGED_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEKCPJMGCOC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEKCPJMGCOC(MEKCPJMGCOC other)
		: this()
	{
		groupId_ = other.groupId_;
		nHGHEBJCCCO_ = other.nHGHEBJCCCO_;
		cOOOFFKIDMC_ = other.cOOOFFKIDMC_;
		retcode_ = other.retcode_;
		jCCOOAEPGED_ = other.jCCOOAEPGED_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEKCPJMGCOC Clone()
	{
		return new MEKCPJMGCOC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MEKCPJMGCOC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MEKCPJMGCOC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (NHGHEBJCCCO != other.NHGHEBJCCCO)
		{
			return false;
		}
		if (COOOFFKIDMC != other.COOOFFKIDMC)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (JCCOOAEPGED != other.JCCOOAEPGED)
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (NHGHEBJCCCO != 0)
		{
			num ^= NHGHEBJCCCO.GetHashCode();
		}
		if (COOOFFKIDMC != 0)
		{
			num ^= COOOFFKIDMC.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (JCCOOAEPGED != 0)
		{
			num ^= JCCOOAEPGED.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GroupId);
		}
		if (NHGHEBJCCCO != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(NHGHEBJCCCO);
		}
		if (COOOFFKIDMC != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(COOOFFKIDMC);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		if (JCCOOAEPGED != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(JCCOOAEPGED);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (NHGHEBJCCCO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NHGHEBJCCCO);
		}
		if (COOOFFKIDMC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(COOOFFKIDMC);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (JCCOOAEPGED != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JCCOOAEPGED);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MEKCPJMGCOC other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.NHGHEBJCCCO != 0)
			{
				NHGHEBJCCCO = other.NHGHEBJCCCO;
			}
			if (other.COOOFFKIDMC != 0)
			{
				COOOFFKIDMC = other.COOOFFKIDMC;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.JCCOOAEPGED != 0)
			{
				JCCOOAEPGED = other.JCCOOAEPGED;
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
				GroupId = input.ReadUInt32();
				break;
			case 32u:
				NHGHEBJCCCO = input.ReadUInt32();
				break;
			case 40u:
				COOOFFKIDMC = input.ReadUInt32();
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 96u:
				JCCOOAEPGED = input.ReadUInt32();
				break;
			}
		}
	}
}
