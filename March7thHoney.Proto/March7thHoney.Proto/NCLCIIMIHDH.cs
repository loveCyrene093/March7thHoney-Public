using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NCLCIIMIHDH : IMessage<NCLCIIMIHDH>, IMessage, IEquatable<NCLCIIMIHDH>, IDeepCloneable<NCLCIIMIHDH>, IBufferMessage
{
	private static readonly MessageParser<NCLCIIMIHDH> _parser = new MessageParser<NCLCIIMIHDH>(() => new NCLCIIMIHDH());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 1;

	private uint groupId_;

	public const int NFCLJMBLFMKFieldNumber = 3;

	private PlayerChallengePeakRecordBossData nFCLJMBLFMK_;

	public const int DDJIDIKHANHFieldNumber = 11;

	private static readonly FieldCodec<PlayerChallengePeakRecordMobData> _repeated_dDJIDIKHANH_codec = FieldCodec.ForMessage(90u, PlayerChallengePeakRecordMobData.Parser);

	private readonly RepeatedField<PlayerChallengePeakRecordMobData> dDJIDIKHANH_ = new RepeatedField<PlayerChallengePeakRecordMobData>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NCLCIIMIHDH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NCLCIIMIHDHReflection.Descriptor.MessageTypes[0];

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
	public PlayerChallengePeakRecordBossData NFCLJMBLFMK
	{
		get
		{
			return nFCLJMBLFMK_;
		}
		set
		{
			nFCLJMBLFMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PlayerChallengePeakRecordMobData> DDJIDIKHANH => dDJIDIKHANH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCLCIIMIHDH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCLCIIMIHDH(NCLCIIMIHDH other)
		: this()
	{
		groupId_ = other.groupId_;
		nFCLJMBLFMK_ = ((other.nFCLJMBLFMK_ != null) ? other.nFCLJMBLFMK_.Clone() : null);
		dDJIDIKHANH_ = other.dDJIDIKHANH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCLCIIMIHDH Clone()
	{
		return new NCLCIIMIHDH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NCLCIIMIHDH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NCLCIIMIHDH other)
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
		if (!object.Equals(NFCLJMBLFMK, other.NFCLJMBLFMK))
		{
			return false;
		}
		if (!dDJIDIKHANH_.Equals(other.dDJIDIKHANH_))
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
		if (nFCLJMBLFMK_ != null)
		{
			num ^= NFCLJMBLFMK.GetHashCode();
		}
		num ^= dDJIDIKHANH_.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(GroupId);
		}
		if (nFCLJMBLFMK_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(NFCLJMBLFMK);
		}
		dDJIDIKHANH_.WriteTo(ref output, _repeated_dDJIDIKHANH_codec);
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
		if (nFCLJMBLFMK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NFCLJMBLFMK);
		}
		num += dDJIDIKHANH_.CalculateSize(_repeated_dDJIDIKHANH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NCLCIIMIHDH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GroupId != 0)
		{
			GroupId = other.GroupId;
		}
		if (other.nFCLJMBLFMK_ != null)
		{
			if (nFCLJMBLFMK_ == null)
			{
				NFCLJMBLFMK = new PlayerChallengePeakRecordBossData();
			}
			NFCLJMBLFMK.MergeFrom(other.NFCLJMBLFMK);
		}
		dDJIDIKHANH_.Add(other.dDJIDIKHANH_);
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
			case 8u:
				GroupId = input.ReadUInt32();
				break;
			case 26u:
				if (nFCLJMBLFMK_ == null)
				{
					NFCLJMBLFMK = new PlayerChallengePeakRecordBossData();
				}
				input.ReadMessage(NFCLJMBLFMK);
				break;
			case 90u:
				dDJIDIKHANH_.AddEntriesFrom(ref input, _repeated_dDJIDIKHANH_codec);
				break;
			}
		}
	}
}
