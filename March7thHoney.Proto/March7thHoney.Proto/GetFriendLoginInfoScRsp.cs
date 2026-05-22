using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFriendLoginInfoScRsp : IMessage<GetFriendLoginInfoScRsp>, IMessage, IEquatable<GetFriendLoginInfoScRsp>, IDeepCloneable<GetFriendLoginInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetFriendLoginInfoScRsp> _parser = new MessageParser<GetFriendLoginInfoScRsp>(() => new GetFriendLoginInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int FriendUidListFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_friendUidList_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> friendUidList_ = new RepeatedField<uint>();

	public const int BKJJFEHPNAOFieldNumber = 5;

	private bool bKJJFEHPNAO_;

	public const int LABBELBJKIIFieldNumber = 11;

	private bool lABBELBJKII_;

	public const int BHJONHOLEAAFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_bHJONHOLEAA_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> bHJONHOLEAA_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFriendLoginInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFriendLoginInfoScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<uint> FriendUidList => friendUidList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BKJJFEHPNAO
	{
		get
		{
			return bKJJFEHPNAO_;
		}
		set
		{
			bKJJFEHPNAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LABBELBJKII
	{
		get
		{
			return lABBELBJKII_;
		}
		set
		{
			lABBELBJKII_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BHJONHOLEAA => bHJONHOLEAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendLoginInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendLoginInfoScRsp(GetFriendLoginInfoScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		friendUidList_ = other.friendUidList_.Clone();
		bKJJFEHPNAO_ = other.bKJJFEHPNAO_;
		lABBELBJKII_ = other.lABBELBJKII_;
		bHJONHOLEAA_ = other.bHJONHOLEAA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendLoginInfoScRsp Clone()
	{
		return new GetFriendLoginInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFriendLoginInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFriendLoginInfoScRsp other)
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
		if (!friendUidList_.Equals(other.friendUidList_))
		{
			return false;
		}
		if (BKJJFEHPNAO != other.BKJJFEHPNAO)
		{
			return false;
		}
		if (LABBELBJKII != other.LABBELBJKII)
		{
			return false;
		}
		if (!bHJONHOLEAA_.Equals(other.bHJONHOLEAA_))
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
		num ^= friendUidList_.GetHashCode();
		if (BKJJFEHPNAO)
		{
			num ^= BKJJFEHPNAO.GetHashCode();
		}
		if (LABBELBJKII)
		{
			num ^= LABBELBJKII.GetHashCode();
		}
		num ^= bHJONHOLEAA_.GetHashCode();
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
		friendUidList_.WriteTo(ref output, _repeated_friendUidList_codec);
		if (BKJJFEHPNAO)
		{
			output.WriteRawTag(40);
			output.WriteBool(BKJJFEHPNAO);
		}
		if (LABBELBJKII)
		{
			output.WriteRawTag(88);
			output.WriteBool(LABBELBJKII);
		}
		bHJONHOLEAA_.WriteTo(ref output, _repeated_bHJONHOLEAA_codec);
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
		num += friendUidList_.CalculateSize(_repeated_friendUidList_codec);
		if (BKJJFEHPNAO)
		{
			num += 2;
		}
		if (LABBELBJKII)
		{
			num += 2;
		}
		num += bHJONHOLEAA_.CalculateSize(_repeated_bHJONHOLEAA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetFriendLoginInfoScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			friendUidList_.Add(other.friendUidList_);
			if (other.BKJJFEHPNAO)
			{
				BKJJFEHPNAO = other.BKJJFEHPNAO;
			}
			if (other.LABBELBJKII)
			{
				LABBELBJKII = other.LABBELBJKII;
			}
			bHJONHOLEAA_.Add(other.bHJONHOLEAA_);
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
				Retcode = input.ReadUInt32();
				break;
			case 24u:
			case 26u:
				friendUidList_.AddEntriesFrom(ref input, _repeated_friendUidList_codec);
				break;
			case 40u:
				BKJJFEHPNAO = input.ReadBool();
				break;
			case 88u:
				LABBELBJKII = input.ReadBool();
				break;
			case 104u:
			case 106u:
				bHJONHOLEAA_.AddEntriesFrom(ref input, _repeated_bHJONHOLEAA_codec);
				break;
			}
		}
	}
}
