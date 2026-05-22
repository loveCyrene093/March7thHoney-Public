using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KMNAKOBKPFF : IMessage<KMNAKOBKPFF>, IMessage, IEquatable<KMNAKOBKPFF>, IDeepCloneable<KMNAKOBKPFF>, IBufferMessage
{
	private static readonly MessageParser<KMNAKOBKPFF> _parser = new MessageParser<KMNAKOBKPFF>(() => new KMNAKOBKPFF());

	private UnknownFieldSet _unknownFields;

	public const int TraitIdFieldNumber = 8;

	private uint traitId_;

	public const int KINIKFCKGDFFieldNumber = 9;

	private uint kINIKFCKGDF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KMNAKOBKPFF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KMNAKOBKPFFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint KINIKFCKGDF
	{
		get
		{
			return kINIKFCKGDF_;
		}
		set
		{
			kINIKFCKGDF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMNAKOBKPFF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMNAKOBKPFF(KMNAKOBKPFF other)
		: this()
	{
		traitId_ = other.traitId_;
		kINIKFCKGDF_ = other.kINIKFCKGDF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMNAKOBKPFF Clone()
	{
		return new KMNAKOBKPFF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KMNAKOBKPFF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KMNAKOBKPFF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TraitId != other.TraitId)
		{
			return false;
		}
		if (KINIKFCKGDF != other.KINIKFCKGDF)
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
		if (TraitId != 0)
		{
			num ^= TraitId.GetHashCode();
		}
		if (KINIKFCKGDF != 0)
		{
			num ^= KINIKFCKGDF.GetHashCode();
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
		if (TraitId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(TraitId);
		}
		if (KINIKFCKGDF != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(KINIKFCKGDF);
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
		if (TraitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TraitId);
		}
		if (KINIKFCKGDF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KINIKFCKGDF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KMNAKOBKPFF other)
	{
		if (other != null)
		{
			if (other.TraitId != 0)
			{
				TraitId = other.TraitId;
			}
			if (other.KINIKFCKGDF != 0)
			{
				KINIKFCKGDF = other.KINIKFCKGDF;
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
			case 64u:
				TraitId = input.ReadUInt32();
				break;
			case 72u:
				KINIKFCKGDF = input.ReadUInt32();
				break;
			}
		}
	}
}
