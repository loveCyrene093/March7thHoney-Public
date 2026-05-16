using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MFHOJCCILLC : IMessage<MFHOJCCILLC>, IMessage, IEquatable<MFHOJCCILLC>, IDeepCloneable<MFHOJCCILLC>, IBufferMessage
{
	private static readonly MessageParser<MFHOJCCILLC> _parser = new MessageParser<MFHOJCCILLC>(() => new MFHOJCCILLC());

	private UnknownFieldSet _unknownFields;

	public const int DFIBLJIHLGLFieldNumber = 8;

	private uint dFIBLJIHLGL_;

	public const int FEKIOHOJBHEFieldNumber = 9;

	private uint fEKIOHOJBHE_;

	public const int LEHOBFFMGBLFieldNumber = 13;

	private uint lEHOBFFMGBL_;

	public const int AreaIdFieldNumber = 14;

	private uint areaId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MFHOJCCILLC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MFHOJCCILLCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DFIBLJIHLGL
	{
		get
		{
			return dFIBLJIHLGL_;
		}
		set
		{
			dFIBLJIHLGL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FEKIOHOJBHE
	{
		get
		{
			return fEKIOHOJBHE_;
		}
		set
		{
			fEKIOHOJBHE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LEHOBFFMGBL
	{
		get
		{
			return lEHOBFFMGBL_;
		}
		set
		{
			lEHOBFFMGBL_ = value;
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
	public MFHOJCCILLC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MFHOJCCILLC(MFHOJCCILLC other)
		: this()
	{
		dFIBLJIHLGL_ = other.dFIBLJIHLGL_;
		fEKIOHOJBHE_ = other.fEKIOHOJBHE_;
		lEHOBFFMGBL_ = other.lEHOBFFMGBL_;
		areaId_ = other.areaId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MFHOJCCILLC Clone()
	{
		return new MFHOJCCILLC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MFHOJCCILLC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MFHOJCCILLC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DFIBLJIHLGL != other.DFIBLJIHLGL)
		{
			return false;
		}
		if (FEKIOHOJBHE != other.FEKIOHOJBHE)
		{
			return false;
		}
		if (LEHOBFFMGBL != other.LEHOBFFMGBL)
		{
			return false;
		}
		if (AreaId != other.AreaId)
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
		if (DFIBLJIHLGL != 0)
		{
			num ^= DFIBLJIHLGL.GetHashCode();
		}
		if (FEKIOHOJBHE != 0)
		{
			num ^= FEKIOHOJBHE.GetHashCode();
		}
		if (LEHOBFFMGBL != 0)
		{
			num ^= LEHOBFFMGBL.GetHashCode();
		}
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
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
		if (DFIBLJIHLGL != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(DFIBLJIHLGL);
		}
		if (FEKIOHOJBHE != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(FEKIOHOJBHE);
		}
		if (LEHOBFFMGBL != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(LEHOBFFMGBL);
		}
		if (AreaId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(AreaId);
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
		if (DFIBLJIHLGL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DFIBLJIHLGL);
		}
		if (FEKIOHOJBHE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FEKIOHOJBHE);
		}
		if (LEHOBFFMGBL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LEHOBFFMGBL);
		}
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MFHOJCCILLC other)
	{
		if (other != null)
		{
			if (other.DFIBLJIHLGL != 0)
			{
				DFIBLJIHLGL = other.DFIBLJIHLGL;
			}
			if (other.FEKIOHOJBHE != 0)
			{
				FEKIOHOJBHE = other.FEKIOHOJBHE;
			}
			if (other.LEHOBFFMGBL != 0)
			{
				LEHOBFFMGBL = other.LEHOBFFMGBL;
			}
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
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
			case 64u:
				DFIBLJIHLGL = input.ReadUInt32();
				break;
			case 72u:
				FEKIOHOJBHE = input.ReadUInt32();
				break;
			case 104u:
				LEHOBFFMGBL = input.ReadUInt32();
				break;
			case 112u:
				AreaId = input.ReadUInt32();
				break;
			}
		}
	}
}
