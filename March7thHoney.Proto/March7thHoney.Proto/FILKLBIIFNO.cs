using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FILKLBIIFNO : IMessage<FILKLBIIFNO>, IMessage, IEquatable<FILKLBIIFNO>, IDeepCloneable<FILKLBIIFNO>, IBufferMessage
{
	private static readonly MessageParser<FILKLBIIFNO> _parser = new MessageParser<FILKLBIIFNO>(() => new FILKLBIIFNO());

	private UnknownFieldSet _unknownFields;

	public const int KKGIEENCOICFieldNumber = 3;

	private uint kKGIEENCOIC_;

	public const int IPMGLMJFGNPFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_iPMGLMJFGNP_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> iPMGLMJFGNP_ = new RepeatedField<uint>();

	public const int FCLMNMMGCMJFieldNumber = 7;

	private uint fCLMNMMGCMJ_;

	public const int AvatarIdFieldNumber = 14;

	private uint avatarId_;

	public const int IJPDHNCJBOKFieldNumber = 15;

	private uint iJPDHNCJBOK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FILKLBIIFNO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FILKLBIIFNOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KKGIEENCOIC
	{
		get
		{
			return kKGIEENCOIC_;
		}
		set
		{
			kKGIEENCOIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IPMGLMJFGNP => iPMGLMJFGNP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCLMNMMGCMJ
	{
		get
		{
			return fCLMNMMGCMJ_;
		}
		set
		{
			fCLMNMMGCMJ_ = value;
		}
	}

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
	public uint IJPDHNCJBOK
	{
		get
		{
			return iJPDHNCJBOK_;
		}
		set
		{
			iJPDHNCJBOK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FILKLBIIFNO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FILKLBIIFNO(FILKLBIIFNO other)
		: this()
	{
		kKGIEENCOIC_ = other.kKGIEENCOIC_;
		iPMGLMJFGNP_ = other.iPMGLMJFGNP_.Clone();
		fCLMNMMGCMJ_ = other.fCLMNMMGCMJ_;
		avatarId_ = other.avatarId_;
		iJPDHNCJBOK_ = other.iJPDHNCJBOK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FILKLBIIFNO Clone()
	{
		return new FILKLBIIFNO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FILKLBIIFNO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FILKLBIIFNO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KKGIEENCOIC != other.KKGIEENCOIC)
		{
			return false;
		}
		if (!iPMGLMJFGNP_.Equals(other.iPMGLMJFGNP_))
		{
			return false;
		}
		if (FCLMNMMGCMJ != other.FCLMNMMGCMJ)
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (IJPDHNCJBOK != other.IJPDHNCJBOK)
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
		if (KKGIEENCOIC != 0)
		{
			num ^= KKGIEENCOIC.GetHashCode();
		}
		num ^= iPMGLMJFGNP_.GetHashCode();
		if (FCLMNMMGCMJ != 0)
		{
			num ^= FCLMNMMGCMJ.GetHashCode();
		}
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (IJPDHNCJBOK != 0)
		{
			num ^= IJPDHNCJBOK.GetHashCode();
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
		if (KKGIEENCOIC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(KKGIEENCOIC);
		}
		iPMGLMJFGNP_.WriteTo(ref output, _repeated_iPMGLMJFGNP_codec);
		if (FCLMNMMGCMJ != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(FCLMNMMGCMJ);
		}
		if (AvatarId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(AvatarId);
		}
		if (IJPDHNCJBOK != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(IJPDHNCJBOK);
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
		if (KKGIEENCOIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKGIEENCOIC);
		}
		num += iPMGLMJFGNP_.CalculateSize(_repeated_iPMGLMJFGNP_codec);
		if (FCLMNMMGCMJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCLMNMMGCMJ);
		}
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (IJPDHNCJBOK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IJPDHNCJBOK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FILKLBIIFNO other)
	{
		if (other != null)
		{
			if (other.KKGIEENCOIC != 0)
			{
				KKGIEENCOIC = other.KKGIEENCOIC;
			}
			iPMGLMJFGNP_.Add(other.iPMGLMJFGNP_);
			if (other.FCLMNMMGCMJ != 0)
			{
				FCLMNMMGCMJ = other.FCLMNMMGCMJ;
			}
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.IJPDHNCJBOK != 0)
			{
				IJPDHNCJBOK = other.IJPDHNCJBOK;
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
			case 24u:
				KKGIEENCOIC = input.ReadUInt32();
				break;
			case 32u:
			case 34u:
				iPMGLMJFGNP_.AddEntriesFrom(ref input, _repeated_iPMGLMJFGNP_codec);
				break;
			case 56u:
				FCLMNMMGCMJ = input.ReadUInt32();
				break;
			case 112u:
				AvatarId = input.ReadUInt32();
				break;
			case 120u:
				IJPDHNCJBOK = input.ReadUInt32();
				break;
			}
		}
	}
}
