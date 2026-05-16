using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IdleLiveEndDungeonCsReq : IMessage<IdleLiveEndDungeonCsReq>, IMessage, IEquatable<IdleLiveEndDungeonCsReq>, IDeepCloneable<IdleLiveEndDungeonCsReq>, IBufferMessage
{
	private static readonly MessageParser<IdleLiveEndDungeonCsReq> _parser = new MessageParser<IdleLiveEndDungeonCsReq>(() => new IdleLiveEndDungeonCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LDJKEEPNJDCFieldNumber = 7;

	private bool lDJKEEPNJDC_;

	public const int MNLBMALDPEJFieldNumber = 8;

	private KFNFHIAEKIN mNLBMALDPEJ_;

	public const int IGGKKDPJDBEFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_iGGKKDPJDBE_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> iGGKKDPJDBE_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IdleLiveEndDungeonCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IdleLiveEndDungeonCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LDJKEEPNJDC
	{
		get
		{
			return lDJKEEPNJDC_;
		}
		set
		{
			lDJKEEPNJDC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFNFHIAEKIN MNLBMALDPEJ
	{
		get
		{
			return mNLBMALDPEJ_;
		}
		set
		{
			mNLBMALDPEJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IGGKKDPJDBE => iGGKKDPJDBE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveEndDungeonCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveEndDungeonCsReq(IdleLiveEndDungeonCsReq other)
		: this()
	{
		lDJKEEPNJDC_ = other.lDJKEEPNJDC_;
		mNLBMALDPEJ_ = ((other.mNLBMALDPEJ_ != null) ? other.mNLBMALDPEJ_.Clone() : null);
		iGGKKDPJDBE_ = other.iGGKKDPJDBE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveEndDungeonCsReq Clone()
	{
		return new IdleLiveEndDungeonCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IdleLiveEndDungeonCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IdleLiveEndDungeonCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LDJKEEPNJDC != other.LDJKEEPNJDC)
		{
			return false;
		}
		if (!object.Equals(MNLBMALDPEJ, other.MNLBMALDPEJ))
		{
			return false;
		}
		if (!iGGKKDPJDBE_.Equals(other.iGGKKDPJDBE_))
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
		if (LDJKEEPNJDC)
		{
			num ^= LDJKEEPNJDC.GetHashCode();
		}
		if (mNLBMALDPEJ_ != null)
		{
			num ^= MNLBMALDPEJ.GetHashCode();
		}
		num ^= iGGKKDPJDBE_.GetHashCode();
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
		if (LDJKEEPNJDC)
		{
			output.WriteRawTag(56);
			output.WriteBool(LDJKEEPNJDC);
		}
		if (mNLBMALDPEJ_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(MNLBMALDPEJ);
		}
		iGGKKDPJDBE_.WriteTo(ref output, _repeated_iGGKKDPJDBE_codec);
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
		if (LDJKEEPNJDC)
		{
			num += 2;
		}
		if (mNLBMALDPEJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MNLBMALDPEJ);
		}
		num += iGGKKDPJDBE_.CalculateSize(_repeated_iGGKKDPJDBE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IdleLiveEndDungeonCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.LDJKEEPNJDC)
		{
			LDJKEEPNJDC = other.LDJKEEPNJDC;
		}
		if (other.mNLBMALDPEJ_ != null)
		{
			if (mNLBMALDPEJ_ == null)
			{
				MNLBMALDPEJ = new KFNFHIAEKIN();
			}
			MNLBMALDPEJ.MergeFrom(other.MNLBMALDPEJ);
		}
		iGGKKDPJDBE_.Add(other.iGGKKDPJDBE_);
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
			case 56u:
				LDJKEEPNJDC = input.ReadBool();
				break;
			case 66u:
				if (mNLBMALDPEJ_ == null)
				{
					MNLBMALDPEJ = new KFNFHIAEKIN();
				}
				input.ReadMessage(MNLBMALDPEJ);
				break;
			case 120u:
			case 122u:
				iGGKKDPJDBE_.AddEntriesFrom(ref input, _repeated_iGGKKDPJDBE_codec);
				break;
			}
		}
	}
}
