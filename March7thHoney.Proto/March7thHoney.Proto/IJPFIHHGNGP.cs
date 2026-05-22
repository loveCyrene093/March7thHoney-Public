using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IJPFIHHGNGP : IMessage<IJPFIHHGNGP>, IMessage, IEquatable<IJPFIHHGNGP>, IDeepCloneable<IJPFIHHGNGP>, IBufferMessage
{
	private static readonly MessageParser<IJPFIHHGNGP> _parser = new MessageParser<IJPFIHHGNGP>(() => new IJPFIHHGNGP());

	private UnknownFieldSet _unknownFields;

	public const int FKFJACFMKKNFieldNumber = 4;

	private uint fKFJACFMKKN_;

	public const int IGLOPONKHKMFieldNumber = 10;

	private uint iGLOPONKHKM_;

	public const int EquipmentGoodsInfoFieldNumber = 14;

	private BMOEEKGCJAD equipmentGoodsInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IJPFIHHGNGP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IJPFIHHGNGPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FKFJACFMKKN
	{
		get
		{
			return fKFJACFMKKN_;
		}
		set
		{
			fKFJACFMKKN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IGLOPONKHKM
	{
		get
		{
			return iGLOPONKHKM_;
		}
		set
		{
			iGLOPONKHKM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BMOEEKGCJAD EquipmentGoodsInfo
	{
		get
		{
			return equipmentGoodsInfo_;
		}
		set
		{
			equipmentGoodsInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJPFIHHGNGP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJPFIHHGNGP(IJPFIHHGNGP other)
		: this()
	{
		fKFJACFMKKN_ = other.fKFJACFMKKN_;
		iGLOPONKHKM_ = other.iGLOPONKHKM_;
		equipmentGoodsInfo_ = ((other.equipmentGoodsInfo_ != null) ? other.equipmentGoodsInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJPFIHHGNGP Clone()
	{
		return new IJPFIHHGNGP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IJPFIHHGNGP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IJPFIHHGNGP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FKFJACFMKKN != other.FKFJACFMKKN)
		{
			return false;
		}
		if (IGLOPONKHKM != other.IGLOPONKHKM)
		{
			return false;
		}
		if (!object.Equals(EquipmentGoodsInfo, other.EquipmentGoodsInfo))
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
		if (FKFJACFMKKN != 0)
		{
			num ^= FKFJACFMKKN.GetHashCode();
		}
		if (IGLOPONKHKM != 0)
		{
			num ^= IGLOPONKHKM.GetHashCode();
		}
		if (equipmentGoodsInfo_ != null)
		{
			num ^= EquipmentGoodsInfo.GetHashCode();
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
		if (FKFJACFMKKN != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(FKFJACFMKKN);
		}
		if (IGLOPONKHKM != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(IGLOPONKHKM);
		}
		if (equipmentGoodsInfo_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(EquipmentGoodsInfo);
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
		if (FKFJACFMKKN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FKFJACFMKKN);
		}
		if (IGLOPONKHKM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IGLOPONKHKM);
		}
		if (equipmentGoodsInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EquipmentGoodsInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IJPFIHHGNGP other)
	{
		if (other == null)
		{
			return;
		}
		if (other.FKFJACFMKKN != 0)
		{
			FKFJACFMKKN = other.FKFJACFMKKN;
		}
		if (other.IGLOPONKHKM != 0)
		{
			IGLOPONKHKM = other.IGLOPONKHKM;
		}
		if (other.equipmentGoodsInfo_ != null)
		{
			if (equipmentGoodsInfo_ == null)
			{
				EquipmentGoodsInfo = new BMOEEKGCJAD();
			}
			EquipmentGoodsInfo.MergeFrom(other.EquipmentGoodsInfo);
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
			case 32u:
				FKFJACFMKKN = input.ReadUInt32();
				break;
			case 80u:
				IGLOPONKHKM = input.ReadUInt32();
				break;
			case 114u:
				if (equipmentGoodsInfo_ == null)
				{
					EquipmentGoodsInfo = new BMOEEKGCJAD();
				}
				input.ReadMessage(EquipmentGoodsInfo);
				break;
			}
		}
	}
}
