using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GPHODKCPCHG : IMessage<GPHODKCPCHG>, IMessage, IEquatable<GPHODKCPCHG>, IDeepCloneable<GPHODKCPCHG>, IBufferMessage
{
	private static readonly MessageParser<GPHODKCPCHG> _parser = new MessageParser<GPHODKCPCHG>(() => new GPHODKCPCHG());

	private UnknownFieldSet _unknownFields;

	public const int EDGEHIDLDBFFieldNumber = 6;

	private bool eDGEHIDLDBF_;

	public const int TraitIdFieldNumber = 15;

	private uint traitId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GPHODKCPCHG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GPHODKCPCHGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EDGEHIDLDBF
	{
		get
		{
			return eDGEHIDLDBF_;
		}
		set
		{
			eDGEHIDLDBF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TraitId
	{
		get
		{
			return traitId_;
		}
		set
		{
			traitId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPHODKCPCHG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPHODKCPCHG(GPHODKCPCHG other)
		: this()
	{
		eDGEHIDLDBF_ = other.eDGEHIDLDBF_;
		traitId_ = other.traitId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPHODKCPCHG Clone()
	{
		return new GPHODKCPCHG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GPHODKCPCHG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GPHODKCPCHG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EDGEHIDLDBF != other.EDGEHIDLDBF)
		{
			return false;
		}
		if (TraitId != other.TraitId)
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
		if (EDGEHIDLDBF)
		{
			num ^= EDGEHIDLDBF.GetHashCode();
		}
		if (TraitId != 0)
		{
			num ^= TraitId.GetHashCode();
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
		if (EDGEHIDLDBF)
		{
			output.WriteRawTag(48);
			output.WriteBool(EDGEHIDLDBF);
		}
		if (TraitId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(TraitId);
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
		if (EDGEHIDLDBF)
		{
			num += 2;
		}
		if (TraitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TraitId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GPHODKCPCHG other)
	{
		if (other != null)
		{
			if (other.EDGEHIDLDBF)
			{
				EDGEHIDLDBF = other.EDGEHIDLDBF;
			}
			if (other.TraitId != 0)
			{
				TraitId = other.TraitId;
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
			case 48u:
				EDGEHIDLDBF = input.ReadBool();
				break;
			case 120u:
				TraitId = input.ReadUInt32();
				break;
			}
		}
	}
}
