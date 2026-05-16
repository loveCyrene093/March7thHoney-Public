using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetMonopolyFriendRankingListScRsp : IMessage<GetMonopolyFriendRankingListScRsp>, IMessage, IEquatable<GetMonopolyFriendRankingListScRsp>, IDeepCloneable<GetMonopolyFriendRankingListScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetMonopolyFriendRankingListScRsp> _parser = new MessageParser<GetMonopolyFriendRankingListScRsp>(() => new GetMonopolyFriendRankingListScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int JPNALKEFHOHFieldNumber = 4;

	private static readonly FieldCodec<GetMonopolyFriendRankingListCsReq> _repeated_jPNALKEFHOH_codec = FieldCodec.ForMessage(34u, GetMonopolyFriendRankingListCsReq.Parser);

	private readonly RepeatedField<GetMonopolyFriendRankingListCsReq> jPNALKEFHOH_ = new RepeatedField<GetMonopolyFriendRankingListCsReq>();

	public const int KNNIAEBMHGMFieldNumber = 6;

	private GetMonopolyFriendRankingListCsReq kNNIAEBMHGM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetMonopolyFriendRankingListScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetMonopolyFriendRankingListScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<GetMonopolyFriendRankingListCsReq> JPNALKEFHOH => jPNALKEFHOH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMonopolyFriendRankingListCsReq KNNIAEBMHGM
	{
		get
		{
			return kNNIAEBMHGM_;
		}
		set
		{
			kNNIAEBMHGM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMonopolyFriendRankingListScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMonopolyFriendRankingListScRsp(GetMonopolyFriendRankingListScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		jPNALKEFHOH_ = other.jPNALKEFHOH_.Clone();
		kNNIAEBMHGM_ = ((other.kNNIAEBMHGM_ != null) ? other.kNNIAEBMHGM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMonopolyFriendRankingListScRsp Clone()
	{
		return new GetMonopolyFriendRankingListScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetMonopolyFriendRankingListScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetMonopolyFriendRankingListScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!jPNALKEFHOH_.Equals(other.jPNALKEFHOH_))
		{
			return false;
		}
		if (!object.Equals(KNNIAEBMHGM, other.KNNIAEBMHGM))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= jPNALKEFHOH_.GetHashCode();
		if (kNNIAEBMHGM_ != null)
		{
			num ^= KNNIAEBMHGM.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		jPNALKEFHOH_.WriteTo(ref output, _repeated_jPNALKEFHOH_codec);
		if (kNNIAEBMHGM_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(KNNIAEBMHGM);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += jPNALKEFHOH_.CalculateSize(_repeated_jPNALKEFHOH_codec);
		if (kNNIAEBMHGM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KNNIAEBMHGM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetMonopolyFriendRankingListScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		jPNALKEFHOH_.Add(other.jPNALKEFHOH_);
		if (other.kNNIAEBMHGM_ != null)
		{
			if (kNNIAEBMHGM_ == null)
			{
				KNNIAEBMHGM = new GetMonopolyFriendRankingListCsReq();
			}
			KNNIAEBMHGM.MergeFrom(other.KNNIAEBMHGM);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				Retcode = input.ReadUInt32();
				break;
			case 34u:
				jPNALKEFHOH_.AddEntriesFrom(ref input, _repeated_jPNALKEFHOH_codec);
				break;
			case 50u:
				if (kNNIAEBMHGM_ == null)
				{
					KNNIAEBMHGM = new GetMonopolyFriendRankingListCsReq();
				}
				input.ReadMessage(KNNIAEBMHGM);
				break;
			}
		}
	}
}
