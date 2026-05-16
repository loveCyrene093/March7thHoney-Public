using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesDeliverPamCargoScRsp : IMessage<PlanetFesDeliverPamCargoScRsp>, IMessage, IEquatable<PlanetFesDeliverPamCargoScRsp>, IDeepCloneable<PlanetFesDeliverPamCargoScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesDeliverPamCargoScRsp> _parser = new MessageParser<PlanetFesDeliverPamCargoScRsp>(() => new PlanetFesDeliverPamCargoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int IOLKDNAMDCOFieldNumber = 8;

	private HLLCDBLCIPK iOLKDNAMDCO_;

	public const int DIHECIIKELEFieldNumber = 10;

	private JIPACDEJKJC dIHECIIKELE_;

	public const int AvatarIdFieldNumber = 14;

	private uint avatarId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesDeliverPamCargoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesDeliverPamCargoScRspReflection.Descriptor.MessageTypes[0];

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
	public HLLCDBLCIPK IOLKDNAMDCO
	{
		get
		{
			return iOLKDNAMDCO_;
		}
		set
		{
			iOLKDNAMDCO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIPACDEJKJC DIHECIIKELE
	{
		get
		{
			return dIHECIIKELE_;
		}
		set
		{
			dIHECIIKELE_ = value;
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
	public PlanetFesDeliverPamCargoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesDeliverPamCargoScRsp(PlanetFesDeliverPamCargoScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		iOLKDNAMDCO_ = ((other.iOLKDNAMDCO_ != null) ? other.iOLKDNAMDCO_.Clone() : null);
		dIHECIIKELE_ = ((other.dIHECIIKELE_ != null) ? other.dIHECIIKELE_.Clone() : null);
		avatarId_ = other.avatarId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesDeliverPamCargoScRsp Clone()
	{
		return new PlanetFesDeliverPamCargoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesDeliverPamCargoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesDeliverPamCargoScRsp other)
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
		if (!object.Equals(IOLKDNAMDCO, other.IOLKDNAMDCO))
		{
			return false;
		}
		if (!object.Equals(DIHECIIKELE, other.DIHECIIKELE))
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
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
		if (iOLKDNAMDCO_ != null)
		{
			num ^= IOLKDNAMDCO.GetHashCode();
		}
		if (dIHECIIKELE_ != null)
		{
			num ^= DIHECIIKELE.GetHashCode();
		}
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (iOLKDNAMDCO_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(IOLKDNAMDCO);
		}
		if (dIHECIIKELE_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(DIHECIIKELE);
		}
		if (AvatarId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(AvatarId);
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
		if (iOLKDNAMDCO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IOLKDNAMDCO);
		}
		if (dIHECIIKELE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DIHECIIKELE);
		}
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesDeliverPamCargoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.iOLKDNAMDCO_ != null)
		{
			if (iOLKDNAMDCO_ == null)
			{
				IOLKDNAMDCO = new HLLCDBLCIPK();
			}
			IOLKDNAMDCO.MergeFrom(other.IOLKDNAMDCO);
		}
		if (other.dIHECIIKELE_ != null)
		{
			if (dIHECIIKELE_ == null)
			{
				DIHECIIKELE = new JIPACDEJKJC();
			}
			DIHECIIKELE.MergeFrom(other.DIHECIIKELE);
		}
		if (other.AvatarId != 0)
		{
			AvatarId = other.AvatarId;
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
				Retcode = input.ReadUInt32();
				break;
			case 66u:
				if (iOLKDNAMDCO_ == null)
				{
					IOLKDNAMDCO = new HLLCDBLCIPK();
				}
				input.ReadMessage(IOLKDNAMDCO);
				break;
			case 82u:
				if (dIHECIIKELE_ == null)
				{
					DIHECIIKELE = new JIPACDEJKJC();
				}
				input.ReadMessage(DIHECIIKELE);
				break;
			case 112u:
				AvatarId = input.ReadUInt32();
				break;
			}
		}
	}
}
