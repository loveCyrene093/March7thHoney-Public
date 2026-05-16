using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DHKFLIKNMJO : IMessage<DHKFLIKNMJO>, IMessage, IEquatable<DHKFLIKNMJO>, IDeepCloneable<DHKFLIKNMJO>, IBufferMessage
{
	private static readonly MessageParser<DHKFLIKNMJO> _parser = new MessageParser<DHKFLIKNMJO>(() => new DHKFLIKNMJO());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 1;

	private uint avatarId_;

	public const int CGFLOHFDKOCFieldNumber = 2;

	private static readonly FieldCodec<EPLFOKKDFLB> _repeated_cGFLOHFDKOC_codec = FieldCodec.ForMessage(18u, EPLFOKKDFLB.Parser);

	private readonly RepeatedField<EPLFOKKDFLB> cGFLOHFDKOC_ = new RepeatedField<EPLFOKKDFLB>();

	public const int KPEGLJJNFDHFieldNumber = 3;

	private static readonly FieldCodec<EPLFOKKDFLB> _repeated_kPEGLJJNFDH_codec = FieldCodec.ForMessage(26u, EPLFOKKDFLB.Parser);

	private readonly RepeatedField<EPLFOKKDFLB> kPEGLJJNFDH_ = new RepeatedField<EPLFOKKDFLB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DHKFLIKNMJO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DHKFLIKNMJOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EPLFOKKDFLB> CGFLOHFDKOC => cGFLOHFDKOC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EPLFOKKDFLB> KPEGLJJNFDH => kPEGLJJNFDH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DHKFLIKNMJO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DHKFLIKNMJO(DHKFLIKNMJO other)
		: this()
	{
		avatarId_ = other.avatarId_;
		cGFLOHFDKOC_ = other.cGFLOHFDKOC_.Clone();
		kPEGLJJNFDH_ = other.kPEGLJJNFDH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DHKFLIKNMJO Clone()
	{
		return new DHKFLIKNMJO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DHKFLIKNMJO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DHKFLIKNMJO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (!cGFLOHFDKOC_.Equals(other.cGFLOHFDKOC_))
		{
			return false;
		}
		if (!kPEGLJJNFDH_.Equals(other.kPEGLJJNFDH_))
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
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		num ^= cGFLOHFDKOC_.GetHashCode();
		num ^= kPEGLJJNFDH_.GetHashCode();
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
		if (AvatarId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AvatarId);
		}
		cGFLOHFDKOC_.WriteTo(ref output, _repeated_cGFLOHFDKOC_codec);
		kPEGLJJNFDH_.WriteTo(ref output, _repeated_kPEGLJJNFDH_codec);
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
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		num += cGFLOHFDKOC_.CalculateSize(_repeated_cGFLOHFDKOC_codec);
		num += kPEGLJJNFDH_.CalculateSize(_repeated_kPEGLJJNFDH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DHKFLIKNMJO other)
	{
		if (other != null)
		{
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			cGFLOHFDKOC_.Add(other.cGFLOHFDKOC_);
			kPEGLJJNFDH_.Add(other.kPEGLJJNFDH_);
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
			case 8u:
				AvatarId = input.ReadUInt32();
				break;
			case 18u:
				cGFLOHFDKOC_.AddEntriesFrom(ref input, _repeated_cGFLOHFDKOC_codec);
				break;
			case 26u:
				kPEGLJJNFDH_.AddEntriesFrom(ref input, _repeated_kPEGLJJNFDH_codec);
				break;
			}
		}
	}
}
