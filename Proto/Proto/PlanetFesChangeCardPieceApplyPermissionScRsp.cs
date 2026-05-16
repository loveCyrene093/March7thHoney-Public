using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesChangeCardPieceApplyPermissionScRsp : IMessage<PlanetFesChangeCardPieceApplyPermissionScRsp>, IMessage, IEquatable<PlanetFesChangeCardPieceApplyPermissionScRsp>, IDeepCloneable<PlanetFesChangeCardPieceApplyPermissionScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesChangeCardPieceApplyPermissionScRsp> _parser = new MessageParser<PlanetFesChangeCardPieceApplyPermissionScRsp>(() => new PlanetFesChangeCardPieceApplyPermissionScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	public const int FLIFCIPEPLOFieldNumber = 15;

	private uint fLIFCIPEPLO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesChangeCardPieceApplyPermissionScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesChangeCardPieceApplyPermissionScRspReflection.Descriptor.MessageTypes[0];

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
	public uint FLIFCIPEPLO
	{
		get
		{
			return fLIFCIPEPLO_;
		}
		set
		{
			fLIFCIPEPLO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesChangeCardPieceApplyPermissionScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesChangeCardPieceApplyPermissionScRsp(PlanetFesChangeCardPieceApplyPermissionScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		fLIFCIPEPLO_ = other.fLIFCIPEPLO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesChangeCardPieceApplyPermissionScRsp Clone()
	{
		return new PlanetFesChangeCardPieceApplyPermissionScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesChangeCardPieceApplyPermissionScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesChangeCardPieceApplyPermissionScRsp other)
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
		if (FLIFCIPEPLO != other.FLIFCIPEPLO)
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
		if (FLIFCIPEPLO != 0)
		{
			num ^= FLIFCIPEPLO.GetHashCode();
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
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
		}
		if (FLIFCIPEPLO != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(FLIFCIPEPLO);
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
		if (FLIFCIPEPLO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FLIFCIPEPLO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesChangeCardPieceApplyPermissionScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.FLIFCIPEPLO != 0)
			{
				FLIFCIPEPLO = other.FLIFCIPEPLO;
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
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			case 120u:
				FLIFCIPEPLO = input.ReadUInt32();
				break;
			}
		}
	}
}
