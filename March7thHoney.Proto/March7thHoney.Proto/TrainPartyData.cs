using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyData : IMessage<TrainPartyData>, IMessage, IEquatable<TrainPartyData>, IDeepCloneable<TrainPartyData>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyData> _parser = new MessageParser<TrainPartyData>(() => new TrainPartyData());

	private UnknownFieldSet _unknownFields;

	public const int GGHOAIDMOMCFieldNumber = 2;

	private FKPMOKOJNHP gGHOAIDMOMC_;

	public const int RecordIdFieldNumber = 4;

	private uint recordId_;

	public const int PassengerInfoFieldNumber = 5;

	private TrainPartyPassengerInfo passengerInfo_;

	public const int TrainPartyInfoFieldNumber = 10;

	private TrainPartyInfo trainPartyInfo_;

	public const int HPHOMPJEDBHFieldNumber = 11;

	private bool hPHOMPJEDBH_;

	public const int KPCHEKDDFMGFieldNumber = 12;

	private uint kPCHEKDDFMG_;

	public const int UnlockAreaNumFieldNumber = 15;

	private uint unlockAreaNum_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FKPMOKOJNHP GGHOAIDMOMC
	{
		get
		{
			return gGHOAIDMOMC_;
		}
		set
		{
			gGHOAIDMOMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RecordId
	{
		get
		{
			return recordId_;
		}
		set
		{
			recordId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyPassengerInfo PassengerInfo
	{
		get
		{
			return passengerInfo_;
		}
		set
		{
			passengerInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyInfo TrainPartyInfo
	{
		get
		{
			return trainPartyInfo_;
		}
		set
		{
			trainPartyInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HPHOMPJEDBH
	{
		get
		{
			return hPHOMPJEDBH_;
		}
		set
		{
			hPHOMPJEDBH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KPCHEKDDFMG
	{
		get
		{
			return kPCHEKDDFMG_;
		}
		set
		{
			kPCHEKDDFMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UnlockAreaNum
	{
		get
		{
			return unlockAreaNum_;
		}
		set
		{
			unlockAreaNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyData(TrainPartyData other)
		: this()
	{
		gGHOAIDMOMC_ = ((other.gGHOAIDMOMC_ != null) ? other.gGHOAIDMOMC_.Clone() : null);
		recordId_ = other.recordId_;
		passengerInfo_ = ((other.passengerInfo_ != null) ? other.passengerInfo_.Clone() : null);
		trainPartyInfo_ = ((other.trainPartyInfo_ != null) ? other.trainPartyInfo_.Clone() : null);
		hPHOMPJEDBH_ = other.hPHOMPJEDBH_;
		kPCHEKDDFMG_ = other.kPCHEKDDFMG_;
		unlockAreaNum_ = other.unlockAreaNum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyData Clone()
	{
		return new TrainPartyData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GGHOAIDMOMC, other.GGHOAIDMOMC))
		{
			return false;
		}
		if (RecordId != other.RecordId)
		{
			return false;
		}
		if (!object.Equals(PassengerInfo, other.PassengerInfo))
		{
			return false;
		}
		if (!object.Equals(TrainPartyInfo, other.TrainPartyInfo))
		{
			return false;
		}
		if (HPHOMPJEDBH != other.HPHOMPJEDBH)
		{
			return false;
		}
		if (KPCHEKDDFMG != other.KPCHEKDDFMG)
		{
			return false;
		}
		if (UnlockAreaNum != other.UnlockAreaNum)
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
		if (gGHOAIDMOMC_ != null)
		{
			num ^= GGHOAIDMOMC.GetHashCode();
		}
		if (RecordId != 0)
		{
			num ^= RecordId.GetHashCode();
		}
		if (passengerInfo_ != null)
		{
			num ^= PassengerInfo.GetHashCode();
		}
		if (trainPartyInfo_ != null)
		{
			num ^= TrainPartyInfo.GetHashCode();
		}
		if (HPHOMPJEDBH)
		{
			num ^= HPHOMPJEDBH.GetHashCode();
		}
		if (KPCHEKDDFMG != 0)
		{
			num ^= KPCHEKDDFMG.GetHashCode();
		}
		if (UnlockAreaNum != 0)
		{
			num ^= UnlockAreaNum.GetHashCode();
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
		if (gGHOAIDMOMC_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(GGHOAIDMOMC);
		}
		if (RecordId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(RecordId);
		}
		if (passengerInfo_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(PassengerInfo);
		}
		if (trainPartyInfo_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(TrainPartyInfo);
		}
		if (HPHOMPJEDBH)
		{
			output.WriteRawTag(88);
			output.WriteBool(HPHOMPJEDBH);
		}
		if (KPCHEKDDFMG != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(KPCHEKDDFMG);
		}
		if (UnlockAreaNum != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(UnlockAreaNum);
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
		if (gGHOAIDMOMC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GGHOAIDMOMC);
		}
		if (RecordId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RecordId);
		}
		if (passengerInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PassengerInfo);
		}
		if (trainPartyInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TrainPartyInfo);
		}
		if (HPHOMPJEDBH)
		{
			num += 2;
		}
		if (KPCHEKDDFMG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KPCHEKDDFMG);
		}
		if (UnlockAreaNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UnlockAreaNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.gGHOAIDMOMC_ != null)
		{
			if (gGHOAIDMOMC_ == null)
			{
				GGHOAIDMOMC = new FKPMOKOJNHP();
			}
			GGHOAIDMOMC.MergeFrom(other.GGHOAIDMOMC);
		}
		if (other.RecordId != 0)
		{
			RecordId = other.RecordId;
		}
		if (other.passengerInfo_ != null)
		{
			if (passengerInfo_ == null)
			{
				PassengerInfo = new TrainPartyPassengerInfo();
			}
			PassengerInfo.MergeFrom(other.PassengerInfo);
		}
		if (other.trainPartyInfo_ != null)
		{
			if (trainPartyInfo_ == null)
			{
				TrainPartyInfo = new TrainPartyInfo();
			}
			TrainPartyInfo.MergeFrom(other.TrainPartyInfo);
		}
		if (other.HPHOMPJEDBH)
		{
			HPHOMPJEDBH = other.HPHOMPJEDBH;
		}
		if (other.KPCHEKDDFMG != 0)
		{
			KPCHEKDDFMG = other.KPCHEKDDFMG;
		}
		if (other.UnlockAreaNum != 0)
		{
			UnlockAreaNum = other.UnlockAreaNum;
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
			case 18u:
				if (gGHOAIDMOMC_ == null)
				{
					GGHOAIDMOMC = new FKPMOKOJNHP();
				}
				input.ReadMessage(GGHOAIDMOMC);
				break;
			case 32u:
				RecordId = input.ReadUInt32();
				break;
			case 42u:
				if (passengerInfo_ == null)
				{
					PassengerInfo = new TrainPartyPassengerInfo();
				}
				input.ReadMessage(PassengerInfo);
				break;
			case 82u:
				if (trainPartyInfo_ == null)
				{
					TrainPartyInfo = new TrainPartyInfo();
				}
				input.ReadMessage(TrainPartyInfo);
				break;
			case 88u:
				HPHOMPJEDBH = input.ReadBool();
				break;
			case 96u:
				KPCHEKDDFMG = input.ReadUInt32();
				break;
			case 120u:
				UnlockAreaNum = input.ReadUInt32();
				break;
			}
		}
	}
}
