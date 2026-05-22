using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BMPOHNCLHMF : IMessage<BMPOHNCLHMF>, IMessage, IEquatable<BMPOHNCLHMF>, IDeepCloneable<BMPOHNCLHMF>, IBufferMessage
{
	private static readonly MessageParser<BMPOHNCLHMF> _parser = new MessageParser<BMPOHNCLHMF>(() => new BMPOHNCLHMF());

	private UnknownFieldSet _unknownFields;

	public const int ContentIdFieldNumber = 4;

	private uint contentId_;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int GFGFLIHCCODFieldNumber = 9;

	private uint gFGFLIHCCOD_;

	public const int CFKFFEDJDDGFieldNumber = 13;

	private static readonly FieldCodec<CMLEPLPBJCC> _repeated_cFKFFEDJDDG_codec = FieldCodec.ForMessage(106u, CMLEPLPBJCC.Parser);

	private readonly RepeatedField<CMLEPLPBJCC> cFKFFEDJDDG_ = new RepeatedField<CMLEPLPBJCC>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BMPOHNCLHMF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BMPOHNCLHMFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ContentId
	{
		get
		{
			return contentId_;
		}
		set
		{
			contentId_ = value;
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
	public uint GFGFLIHCCOD
	{
		get
		{
			return gFGFLIHCCOD_;
		}
		set
		{
			gFGFLIHCCOD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CMLEPLPBJCC> CFKFFEDJDDG => cFKFFEDJDDG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BMPOHNCLHMF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BMPOHNCLHMF(BMPOHNCLHMF other)
		: this()
	{
		contentId_ = other.contentId_;
		retcode_ = other.retcode_;
		gFGFLIHCCOD_ = other.gFGFLIHCCOD_;
		cFKFFEDJDDG_ = other.cFKFFEDJDDG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BMPOHNCLHMF Clone()
	{
		return new BMPOHNCLHMF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BMPOHNCLHMF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BMPOHNCLHMF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ContentId != other.ContentId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (GFGFLIHCCOD != other.GFGFLIHCCOD)
		{
			return false;
		}
		if (!cFKFFEDJDDG_.Equals(other.cFKFFEDJDDG_))
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
		if (ContentId != 0)
		{
			num ^= ContentId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (GFGFLIHCCOD != 0)
		{
			num ^= GFGFLIHCCOD.GetHashCode();
		}
		num ^= cFKFFEDJDDG_.GetHashCode();
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
		if (ContentId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(ContentId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		if (GFGFLIHCCOD != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(GFGFLIHCCOD);
		}
		cFKFFEDJDDG_.WriteTo(ref output, _repeated_cFKFFEDJDDG_codec);
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
		if (ContentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ContentId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (GFGFLIHCCOD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GFGFLIHCCOD);
		}
		num += cFKFFEDJDDG_.CalculateSize(_repeated_cFKFFEDJDDG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BMPOHNCLHMF other)
	{
		if (other != null)
		{
			if (other.ContentId != 0)
			{
				ContentId = other.ContentId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.GFGFLIHCCOD != 0)
			{
				GFGFLIHCCOD = other.GFGFLIHCCOD;
			}
			cFKFFEDJDDG_.Add(other.cFKFFEDJDDG_);
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
				ContentId = input.ReadUInt32();
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 72u:
				GFGFLIHCCOD = input.ReadUInt32();
				break;
			case 106u:
				cFKFFEDJDDG_.AddEntriesFrom(ref input, _repeated_cFKFFEDJDDG_codec);
				break;
			}
		}
	}
}
