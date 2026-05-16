using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyBuildStartStepCsReq : IMessage<TrainPartyBuildStartStepCsReq>, IMessage, IEquatable<TrainPartyBuildStartStepCsReq>, IDeepCloneable<TrainPartyBuildStartStepCsReq>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyBuildStartStepCsReq> _parser = new MessageParser<TrainPartyBuildStartStepCsReq>(() => new TrainPartyBuildStartStepCsReq());

	private UnknownFieldSet _unknownFields;

	public const int OIGHBOMFGGDFieldNumber = 1;

	private uint oIGHBOMFGGD_;

	public const int AreaIdFieldNumber = 3;

	private uint areaId_;

	public const int FNLNPLHOEJNFieldNumber = 13;

	private uint fNLNPLHOEJN_;

	public const int LMHIBHGINLGFieldNumber = 15;

	private AreaDynamicInfo lMHIBHGINLG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyBuildStartStepCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyBuildStartStepCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OIGHBOMFGGD
	{
		get
		{
			return oIGHBOMFGGD_;
		}
		set
		{
			oIGHBOMFGGD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FNLNPLHOEJN
	{
		get
		{
			return fNLNPLHOEJN_;
		}
		set
		{
			fNLNPLHOEJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AreaDynamicInfo LMHIBHGINLG
	{
		get
		{
			return lMHIBHGINLG_;
		}
		set
		{
			lMHIBHGINLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildStartStepCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildStartStepCsReq(TrainPartyBuildStartStepCsReq other)
		: this()
	{
		oIGHBOMFGGD_ = other.oIGHBOMFGGD_;
		areaId_ = other.areaId_;
		fNLNPLHOEJN_ = other.fNLNPLHOEJN_;
		lMHIBHGINLG_ = ((other.lMHIBHGINLG_ != null) ? other.lMHIBHGINLG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildStartStepCsReq Clone()
	{
		return new TrainPartyBuildStartStepCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyBuildStartStepCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyBuildStartStepCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OIGHBOMFGGD != other.OIGHBOMFGGD)
		{
			return false;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (FNLNPLHOEJN != other.FNLNPLHOEJN)
		{
			return false;
		}
		if (!object.Equals(LMHIBHGINLG, other.LMHIBHGINLG))
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
		if (OIGHBOMFGGD != 0)
		{
			num ^= OIGHBOMFGGD.GetHashCode();
		}
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		if (FNLNPLHOEJN != 0)
		{
			num ^= FNLNPLHOEJN.GetHashCode();
		}
		if (lMHIBHGINLG_ != null)
		{
			num ^= LMHIBHGINLG.GetHashCode();
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
		if (OIGHBOMFGGD != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(OIGHBOMFGGD);
		}
		if (AreaId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(AreaId);
		}
		if (FNLNPLHOEJN != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(FNLNPLHOEJN);
		}
		if (lMHIBHGINLG_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(LMHIBHGINLG);
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
		if (OIGHBOMFGGD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OIGHBOMFGGD);
		}
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (FNLNPLHOEJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FNLNPLHOEJN);
		}
		if (lMHIBHGINLG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LMHIBHGINLG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyBuildStartStepCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.OIGHBOMFGGD != 0)
		{
			OIGHBOMFGGD = other.OIGHBOMFGGD;
		}
		if (other.AreaId != 0)
		{
			AreaId = other.AreaId;
		}
		if (other.FNLNPLHOEJN != 0)
		{
			FNLNPLHOEJN = other.FNLNPLHOEJN;
		}
		if (other.lMHIBHGINLG_ != null)
		{
			if (lMHIBHGINLG_ == null)
			{
				LMHIBHGINLG = new AreaDynamicInfo();
			}
			LMHIBHGINLG.MergeFrom(other.LMHIBHGINLG);
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
			case 8u:
				OIGHBOMFGGD = input.ReadUInt32();
				break;
			case 24u:
				AreaId = input.ReadUInt32();
				break;
			case 104u:
				FNLNPLHOEJN = input.ReadUInt32();
				break;
			case 122u:
				if (lMHIBHGINLG_ == null)
				{
					LMHIBHGINLG = new AreaDynamicInfo();
				}
				input.ReadMessage(LMHIBHGINLG);
				break;
			}
		}
	}
}
