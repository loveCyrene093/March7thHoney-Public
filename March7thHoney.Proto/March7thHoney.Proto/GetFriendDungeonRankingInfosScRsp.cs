using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFriendDungeonRankingInfosScRsp : IMessage<GetFriendDungeonRankingInfosScRsp>, IMessage, IEquatable<GetFriendDungeonRankingInfosScRsp>, IDeepCloneable<GetFriendDungeonRankingInfosScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetFriendDungeonRankingInfosScRsp> _parser = new MessageParser<GetFriendDungeonRankingInfosScRsp>(() => new GetFriendDungeonRankingInfosScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CPBGLNGOCBAFieldNumber = 5;

	private static readonly FieldCodec<CGFBDFHDNGO> _repeated_cPBGLNGOCBA_codec = FieldCodec.ForMessage(42u, CGFBDFHDNGO.Parser);

	private readonly RepeatedField<CGFBDFHDNGO> cPBGLNGOCBA_ = new RepeatedField<CGFBDFHDNGO>();

	public const int BIBPEJMLCMFFieldNumber = 10;

	private uint bIBPEJMLCMF_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFriendDungeonRankingInfosScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFriendDungeonRankingInfosScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CGFBDFHDNGO> CPBGLNGOCBA => cPBGLNGOCBA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BIBPEJMLCMF
	{
		get
		{
			return bIBPEJMLCMF_;
		}
		set
		{
			bIBPEJMLCMF_ = value;
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
	public GetFriendDungeonRankingInfosScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendDungeonRankingInfosScRsp(GetFriendDungeonRankingInfosScRsp other)
		: this()
	{
		cPBGLNGOCBA_ = other.cPBGLNGOCBA_.Clone();
		bIBPEJMLCMF_ = other.bIBPEJMLCMF_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendDungeonRankingInfosScRsp Clone()
	{
		return new GetFriendDungeonRankingInfosScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFriendDungeonRankingInfosScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFriendDungeonRankingInfosScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cPBGLNGOCBA_.Equals(other.cPBGLNGOCBA_))
		{
			return false;
		}
		if (BIBPEJMLCMF != other.BIBPEJMLCMF)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= cPBGLNGOCBA_.GetHashCode();
		if (BIBPEJMLCMF != 0)
		{
			num ^= BIBPEJMLCMF.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		cPBGLNGOCBA_.WriteTo(ref output, _repeated_cPBGLNGOCBA_codec);
		if (BIBPEJMLCMF != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(BIBPEJMLCMF);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Retcode);
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
		num += cPBGLNGOCBA_.CalculateSize(_repeated_cPBGLNGOCBA_codec);
		if (BIBPEJMLCMF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BIBPEJMLCMF);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetFriendDungeonRankingInfosScRsp other)
	{
		if (other != null)
		{
			cPBGLNGOCBA_.Add(other.cPBGLNGOCBA_);
			if (other.BIBPEJMLCMF != 0)
			{
				BIBPEJMLCMF = other.BIBPEJMLCMF;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 42u:
				cPBGLNGOCBA_.AddEntriesFrom(ref input, _repeated_cPBGLNGOCBA_codec);
				break;
			case 80u:
				BIBPEJMLCMF = input.ReadUInt32();
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
