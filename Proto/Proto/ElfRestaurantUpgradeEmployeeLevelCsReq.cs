using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ElfRestaurantUpgradeEmployeeLevelCsReq : IMessage<ElfRestaurantUpgradeEmployeeLevelCsReq>, IMessage, IEquatable<ElfRestaurantUpgradeEmployeeLevelCsReq>, IDeepCloneable<ElfRestaurantUpgradeEmployeeLevelCsReq>, IBufferMessage
{
	private static readonly MessageParser<ElfRestaurantUpgradeEmployeeLevelCsReq> _parser = new MessageParser<ElfRestaurantUpgradeEmployeeLevelCsReq>(() => new ElfRestaurantUpgradeEmployeeLevelCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ODADJILOEKOFieldNumber = 7;

	private uint oDADJILOEKO_;

	public const int MPBBIJMACLLFieldNumber = 11;

	private uint mPBBIJMACLL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ElfRestaurantUpgradeEmployeeLevelCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ElfRestaurantUpgradeEmployeeLevelCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ODADJILOEKO
	{
		get
		{
			return oDADJILOEKO_;
		}
		set
		{
			oDADJILOEKO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MPBBIJMACLL
	{
		get
		{
			return mPBBIJMACLL_;
		}
		set
		{
			mPBBIJMACLL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantUpgradeEmployeeLevelCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantUpgradeEmployeeLevelCsReq(ElfRestaurantUpgradeEmployeeLevelCsReq other)
		: this()
	{
		oDADJILOEKO_ = other.oDADJILOEKO_;
		mPBBIJMACLL_ = other.mPBBIJMACLL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantUpgradeEmployeeLevelCsReq Clone()
	{
		return new ElfRestaurantUpgradeEmployeeLevelCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ElfRestaurantUpgradeEmployeeLevelCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ElfRestaurantUpgradeEmployeeLevelCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ODADJILOEKO != other.ODADJILOEKO)
		{
			return false;
		}
		if (MPBBIJMACLL != other.MPBBIJMACLL)
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
		if (ODADJILOEKO != 0)
		{
			num ^= ODADJILOEKO.GetHashCode();
		}
		if (MPBBIJMACLL != 0)
		{
			num ^= MPBBIJMACLL.GetHashCode();
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
		if (ODADJILOEKO != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ODADJILOEKO);
		}
		if (MPBBIJMACLL != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(MPBBIJMACLL);
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
		if (ODADJILOEKO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ODADJILOEKO);
		}
		if (MPBBIJMACLL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MPBBIJMACLL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ElfRestaurantUpgradeEmployeeLevelCsReq other)
	{
		if (other != null)
		{
			if (other.ODADJILOEKO != 0)
			{
				ODADJILOEKO = other.ODADJILOEKO;
			}
			if (other.MPBBIJMACLL != 0)
			{
				MPBBIJMACLL = other.MPBBIJMACLL;
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
			case 56u:
				ODADJILOEKO = input.ReadUInt32();
				break;
			case 88u:
				MPBBIJMACLL = input.ReadUInt32();
				break;
			}
		}
	}
}
