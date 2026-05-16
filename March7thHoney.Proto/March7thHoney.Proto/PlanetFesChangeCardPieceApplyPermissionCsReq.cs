using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesChangeCardPieceApplyPermissionCsReq : IMessage<PlanetFesChangeCardPieceApplyPermissionCsReq>, IMessage, IEquatable<PlanetFesChangeCardPieceApplyPermissionCsReq>, IDeepCloneable<PlanetFesChangeCardPieceApplyPermissionCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesChangeCardPieceApplyPermissionCsReq> _parser = new MessageParser<PlanetFesChangeCardPieceApplyPermissionCsReq>(() => new PlanetFesChangeCardPieceApplyPermissionCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FLIFCIPEPLOFieldNumber = 8;

	private uint fLIFCIPEPLO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesChangeCardPieceApplyPermissionCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesChangeCardPieceApplyPermissionCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public PlanetFesChangeCardPieceApplyPermissionCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesChangeCardPieceApplyPermissionCsReq(PlanetFesChangeCardPieceApplyPermissionCsReq other)
		: this()
	{
		fLIFCIPEPLO_ = other.fLIFCIPEPLO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesChangeCardPieceApplyPermissionCsReq Clone()
	{
		return new PlanetFesChangeCardPieceApplyPermissionCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesChangeCardPieceApplyPermissionCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesChangeCardPieceApplyPermissionCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		if (FLIFCIPEPLO != 0)
		{
			output.WriteRawTag(64);
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
	public void MergeFrom(PlanetFesChangeCardPieceApplyPermissionCsReq other)
	{
		if (other != null)
		{
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
			if (num != 64)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				FLIFCIPEPLO = input.ReadUInt32();
			}
		}
	}
}
