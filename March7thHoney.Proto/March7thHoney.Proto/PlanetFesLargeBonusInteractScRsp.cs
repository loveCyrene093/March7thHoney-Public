using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesLargeBonusInteractScRsp : IMessage<PlanetFesLargeBonusInteractScRsp>, IMessage, IEquatable<PlanetFesLargeBonusInteractScRsp>, IDeepCloneable<PlanetFesLargeBonusInteractScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesLargeBonusInteractScRsp> _parser = new MessageParser<PlanetFesLargeBonusInteractScRsp>(() => new PlanetFesLargeBonusInteractScRsp());

	private UnknownFieldSet _unknownFields;

	public const int DIHECIIKELEFieldNumber = 6;

	private JIPACDEJKJC dIHECIIKELE_;

	public const int LAMFMELCEMDFieldNumber = 7;

	private EFEGKDHEMFN lAMFMELCEMD_;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	public const int HGIAGJMHDOBFieldNumber = 15;

	private uint hGIAGJMHDOB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesLargeBonusInteractScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesLargeBonusInteractScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public EFEGKDHEMFN LAMFMELCEMD
	{
		get
		{
			return lAMFMELCEMD_;
		}
		set
		{
			lAMFMELCEMD_ = value;
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
	public uint HGIAGJMHDOB
	{
		get
		{
			return hGIAGJMHDOB_;
		}
		set
		{
			hGIAGJMHDOB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesLargeBonusInteractScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesLargeBonusInteractScRsp(PlanetFesLargeBonusInteractScRsp other)
		: this()
	{
		dIHECIIKELE_ = ((other.dIHECIIKELE_ != null) ? other.dIHECIIKELE_.Clone() : null);
		lAMFMELCEMD_ = ((other.lAMFMELCEMD_ != null) ? other.lAMFMELCEMD_.Clone() : null);
		retcode_ = other.retcode_;
		hGIAGJMHDOB_ = other.hGIAGJMHDOB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesLargeBonusInteractScRsp Clone()
	{
		return new PlanetFesLargeBonusInteractScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesLargeBonusInteractScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesLargeBonusInteractScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DIHECIIKELE, other.DIHECIIKELE))
		{
			return false;
		}
		if (!object.Equals(LAMFMELCEMD, other.LAMFMELCEMD))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (HGIAGJMHDOB != other.HGIAGJMHDOB)
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
		if (dIHECIIKELE_ != null)
		{
			num ^= DIHECIIKELE.GetHashCode();
		}
		if (lAMFMELCEMD_ != null)
		{
			num ^= LAMFMELCEMD.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (HGIAGJMHDOB != 0)
		{
			num ^= HGIAGJMHDOB.GetHashCode();
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
		if (dIHECIIKELE_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(DIHECIIKELE);
		}
		if (lAMFMELCEMD_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(LAMFMELCEMD);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
		}
		if (HGIAGJMHDOB != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(HGIAGJMHDOB);
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
		if (dIHECIIKELE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DIHECIIKELE);
		}
		if (lAMFMELCEMD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LAMFMELCEMD);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (HGIAGJMHDOB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HGIAGJMHDOB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesLargeBonusInteractScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.dIHECIIKELE_ != null)
		{
			if (dIHECIIKELE_ == null)
			{
				DIHECIIKELE = new JIPACDEJKJC();
			}
			DIHECIIKELE.MergeFrom(other.DIHECIIKELE);
		}
		if (other.lAMFMELCEMD_ != null)
		{
			if (lAMFMELCEMD_ == null)
			{
				LAMFMELCEMD = new EFEGKDHEMFN();
			}
			LAMFMELCEMD.MergeFrom(other.LAMFMELCEMD);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.HGIAGJMHDOB != 0)
		{
			HGIAGJMHDOB = other.HGIAGJMHDOB;
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
			case 50u:
				if (dIHECIIKELE_ == null)
				{
					DIHECIIKELE = new JIPACDEJKJC();
				}
				input.ReadMessage(DIHECIIKELE);
				break;
			case 58u:
				if (lAMFMELCEMD_ == null)
				{
					LAMFMELCEMD = new EFEGKDHEMFN();
				}
				input.ReadMessage(LAMFMELCEMD);
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			case 120u:
				HGIAGJMHDOB = input.ReadUInt32();
				break;
			}
		}
	}
}
