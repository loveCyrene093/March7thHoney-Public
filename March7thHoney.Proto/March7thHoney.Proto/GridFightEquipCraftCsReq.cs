using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightEquipCraftCsReq : IMessage<GridFightEquipCraftCsReq>, IMessage, IEquatable<GridFightEquipCraftCsReq>, IDeepCloneable<GridFightEquipCraftCsReq>, IBufferMessage
{
	private static readonly MessageParser<GridFightEquipCraftCsReq> _parser = new MessageParser<GridFightEquipCraftCsReq>(() => new GridFightEquipCraftCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CraftMaterialsFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_craftMaterials_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> craftMaterials_ = new RepeatedField<uint>();

	public const int BGEKACPOAOPFieldNumber = 7;

	private uint bGEKACPOAOP_;

	public const int SourceFieldNumber = 8;

	private GridFightEquipCraftSource source_;

	public const int EGLOACDPNLDFieldNumber = 12;

	private uint eGLOACDPNLD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightEquipCraftCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightEquipCraftCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CraftMaterials => craftMaterials_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BGEKACPOAOP
	{
		get
		{
			return bGEKACPOAOP_;
		}
		set
		{
			bGEKACPOAOP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEquipCraftSource Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EGLOACDPNLD
	{
		get
		{
			return eGLOACDPNLD_;
		}
		set
		{
			eGLOACDPNLD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEquipCraftCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEquipCraftCsReq(GridFightEquipCraftCsReq other)
		: this()
	{
		craftMaterials_ = other.craftMaterials_.Clone();
		bGEKACPOAOP_ = other.bGEKACPOAOP_;
		source_ = other.source_;
		eGLOACDPNLD_ = other.eGLOACDPNLD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEquipCraftCsReq Clone()
	{
		return new GridFightEquipCraftCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightEquipCraftCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightEquipCraftCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!craftMaterials_.Equals(other.craftMaterials_))
		{
			return false;
		}
		if (BGEKACPOAOP != other.BGEKACPOAOP)
		{
			return false;
		}
		if (Source != other.Source)
		{
			return false;
		}
		if (EGLOACDPNLD != other.EGLOACDPNLD)
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
		num ^= craftMaterials_.GetHashCode();
		if (BGEKACPOAOP != 0)
		{
			num ^= BGEKACPOAOP.GetHashCode();
		}
		if (Source != GridFightEquipCraftSource.BnmlepcncihAialpdejijk)
		{
			num ^= Source.GetHashCode();
		}
		if (EGLOACDPNLD != 0)
		{
			num ^= EGLOACDPNLD.GetHashCode();
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
		craftMaterials_.WriteTo(ref output, _repeated_craftMaterials_codec);
		if (BGEKACPOAOP != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(BGEKACPOAOP);
		}
		if (Source != GridFightEquipCraftSource.BnmlepcncihAialpdejijk)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)Source);
		}
		if (EGLOACDPNLD != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(EGLOACDPNLD);
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
		num += craftMaterials_.CalculateSize(_repeated_craftMaterials_codec);
		if (BGEKACPOAOP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BGEKACPOAOP);
		}
		if (Source != GridFightEquipCraftSource.BnmlepcncihAialpdejijk)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Source);
		}
		if (EGLOACDPNLD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EGLOACDPNLD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightEquipCraftCsReq other)
	{
		if (other != null)
		{
			craftMaterials_.Add(other.craftMaterials_);
			if (other.BGEKACPOAOP != 0)
			{
				BGEKACPOAOP = other.BGEKACPOAOP;
			}
			if (other.Source != GridFightEquipCraftSource.BnmlepcncihAialpdejijk)
			{
				Source = other.Source;
			}
			if (other.EGLOACDPNLD != 0)
			{
				EGLOACDPNLD = other.EGLOACDPNLD;
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
			case 32u:
			case 34u:
				craftMaterials_.AddEntriesFrom(ref input, _repeated_craftMaterials_codec);
				break;
			case 56u:
				BGEKACPOAOP = input.ReadUInt32();
				break;
			case 64u:
				Source = (GridFightEquipCraftSource)input.ReadEnum();
				break;
			case 96u:
				EGLOACDPNLD = input.ReadUInt32();
				break;
			}
		}
	}
}
