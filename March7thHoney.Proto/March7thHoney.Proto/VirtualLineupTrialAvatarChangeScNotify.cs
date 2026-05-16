using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class VirtualLineupTrialAvatarChangeScNotify : IMessage<VirtualLineupTrialAvatarChangeScNotify>, IMessage, IEquatable<VirtualLineupTrialAvatarChangeScNotify>, IDeepCloneable<VirtualLineupTrialAvatarChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<VirtualLineupTrialAvatarChangeScNotify> _parser = new MessageParser<VirtualLineupTrialAvatarChangeScNotify>(() => new VirtualLineupTrialAvatarChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int PlaneIdFieldNumber = 1;

	private uint planeId_;

	public const int OCAKFNFEPCOFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_oCAKFNFEPCO_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> oCAKFNFEPCO_ = new RepeatedField<uint>();

	public const int OMNHJDBLFNKFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_oMNHJDBLFNK_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> oMNHJDBLFNK_ = new RepeatedField<uint>();

	public const int BPJLLBDDNDMFieldNumber = 15;

	private bool bPJLLBDDNDM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<VirtualLineupTrialAvatarChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => VirtualLineupTrialAvatarChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PlaneId
	{
		get
		{
			return planeId_;
		}
		set
		{
			planeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OCAKFNFEPCO => oCAKFNFEPCO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OMNHJDBLFNK => oMNHJDBLFNK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BPJLLBDDNDM
	{
		get
		{
			return bPJLLBDDNDM_;
		}
		set
		{
			bPJLLBDDNDM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public VirtualLineupTrialAvatarChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public VirtualLineupTrialAvatarChangeScNotify(VirtualLineupTrialAvatarChangeScNotify other)
		: this()
	{
		planeId_ = other.planeId_;
		oCAKFNFEPCO_ = other.oCAKFNFEPCO_.Clone();
		oMNHJDBLFNK_ = other.oMNHJDBLFNK_.Clone();
		bPJLLBDDNDM_ = other.bPJLLBDDNDM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public VirtualLineupTrialAvatarChangeScNotify Clone()
	{
		return new VirtualLineupTrialAvatarChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as VirtualLineupTrialAvatarChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(VirtualLineupTrialAvatarChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PlaneId != other.PlaneId)
		{
			return false;
		}
		if (!oCAKFNFEPCO_.Equals(other.oCAKFNFEPCO_))
		{
			return false;
		}
		if (!oMNHJDBLFNK_.Equals(other.oMNHJDBLFNK_))
		{
			return false;
		}
		if (BPJLLBDDNDM != other.BPJLLBDDNDM)
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
		if (PlaneId != 0)
		{
			num ^= PlaneId.GetHashCode();
		}
		num ^= oCAKFNFEPCO_.GetHashCode();
		num ^= oMNHJDBLFNK_.GetHashCode();
		if (BPJLLBDDNDM)
		{
			num ^= BPJLLBDDNDM.GetHashCode();
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
		if (PlaneId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PlaneId);
		}
		oCAKFNFEPCO_.WriteTo(ref output, _repeated_oCAKFNFEPCO_codec);
		oMNHJDBLFNK_.WriteTo(ref output, _repeated_oMNHJDBLFNK_codec);
		if (BPJLLBDDNDM)
		{
			output.WriteRawTag(120);
			output.WriteBool(BPJLLBDDNDM);
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
		if (PlaneId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PlaneId);
		}
		num += oCAKFNFEPCO_.CalculateSize(_repeated_oCAKFNFEPCO_codec);
		num += oMNHJDBLFNK_.CalculateSize(_repeated_oMNHJDBLFNK_codec);
		if (BPJLLBDDNDM)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(VirtualLineupTrialAvatarChangeScNotify other)
	{
		if (other != null)
		{
			if (other.PlaneId != 0)
			{
				PlaneId = other.PlaneId;
			}
			oCAKFNFEPCO_.Add(other.oCAKFNFEPCO_);
			oMNHJDBLFNK_.Add(other.oMNHJDBLFNK_);
			if (other.BPJLLBDDNDM)
			{
				BPJLLBDDNDM = other.BPJLLBDDNDM;
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
			case 8u:
				PlaneId = input.ReadUInt32();
				break;
			case 48u:
			case 50u:
				oCAKFNFEPCO_.AddEntriesFrom(ref input, _repeated_oCAKFNFEPCO_codec);
				break;
			case 104u:
			case 106u:
				oMNHJDBLFNK_.AddEntriesFrom(ref input, _repeated_oMNHJDBLFNK_codec);
				break;
			case 120u:
				BPJLLBDDNDM = input.ReadBool();
				break;
			}
		}
	}
}
