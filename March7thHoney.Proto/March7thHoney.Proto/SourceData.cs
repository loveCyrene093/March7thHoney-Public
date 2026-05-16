using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SourceData : IMessage<SourceData>, IMessage, IEquatable<SourceData>, IDeepCloneable<SourceData>, IBufferMessage
{
	public enum FPCDPDPHKJJOneofCase
	{
		None = 0,
		Uid = 11,
		RoleGoodsInfo = 12
	}

	private static readonly MessageParser<SourceData> _parser = new MessageParser<SourceData>(() => new SourceData());

	private UnknownFieldSet _unknownFields;

	public const int NIHAJMHKOBCFieldNumber = 1;

	private BKACBGFDDDA nIHAJMHKOBC_;

	public const int UidFieldNumber = 11;

	public const int RoleGoodsInfoFieldNumber = 12;

	private object fPCDPDPHKJJ_;

	private FPCDPDPHKJJOneofCase fPCDPDPHKJJCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SourceData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SourceDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BKACBGFDDDA NIHAJMHKOBC
	{
		get
		{
			return nIHAJMHKOBC_;
		}
		set
		{
			nIHAJMHKOBC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			if (!HasUid)
			{
				return 0u;
			}
			return (uint)fPCDPDPHKJJ_;
		}
		set
		{
			fPCDPDPHKJJ_ = value;
			fPCDPDPHKJJCase_ = FPCDPDPHKJJOneofCase.Uid;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasUid => fPCDPDPHKJJCase_ == FPCDPDPHKJJOneofCase.Uid;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COOCLIPGCEH RoleGoodsInfo
	{
		get
		{
			if (!HasRoleGoodsInfo)
			{
				return COOCLIPGCEH.Pcpdhelpkem;
			}
			return (COOCLIPGCEH)fPCDPDPHKJJ_;
		}
		set
		{
			fPCDPDPHKJJ_ = value;
			fPCDPDPHKJJCase_ = FPCDPDPHKJJOneofCase.RoleGoodsInfo;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasRoleGoodsInfo => fPCDPDPHKJJCase_ == FPCDPDPHKJJOneofCase.RoleGoodsInfo;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPCDPDPHKJJOneofCase FPCDPDPHKJJCase => fPCDPDPHKJJCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SourceData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SourceData(SourceData other)
		: this()
	{
		nIHAJMHKOBC_ = other.nIHAJMHKOBC_;
		switch (other.FPCDPDPHKJJCase)
		{
		case FPCDPDPHKJJOneofCase.Uid:
			Uid = other.Uid;
			break;
		case FPCDPDPHKJJOneofCase.RoleGoodsInfo:
			RoleGoodsInfo = other.RoleGoodsInfo;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SourceData Clone()
	{
		return new SourceData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearUid()
	{
		if (HasUid)
		{
			ClearFPCDPDPHKJJ();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearRoleGoodsInfo()
	{
		if (HasRoleGoodsInfo)
		{
			ClearFPCDPDPHKJJ();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFPCDPDPHKJJ()
	{
		fPCDPDPHKJJCase_ = FPCDPDPHKJJOneofCase.None;
		fPCDPDPHKJJ_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SourceData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SourceData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NIHAJMHKOBC != other.NIHAJMHKOBC)
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (RoleGoodsInfo != other.RoleGoodsInfo)
		{
			return false;
		}
		if (FPCDPDPHKJJCase != other.FPCDPDPHKJJCase)
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
		if (NIHAJMHKOBC != BKACBGFDDDA.BjlejciglaoPcpdhelpkem)
		{
			num ^= NIHAJMHKOBC.GetHashCode();
		}
		if (HasUid)
		{
			num ^= Uid.GetHashCode();
		}
		if (HasRoleGoodsInfo)
		{
			num ^= RoleGoodsInfo.GetHashCode();
		}
		num ^= (int)fPCDPDPHKJJCase_;
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
		if (NIHAJMHKOBC != BKACBGFDDDA.BjlejciglaoPcpdhelpkem)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)NIHAJMHKOBC);
		}
		if (HasUid)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Uid);
		}
		if (HasRoleGoodsInfo)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)RoleGoodsInfo);
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
		if (NIHAJMHKOBC != BKACBGFDDDA.BjlejciglaoPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NIHAJMHKOBC);
		}
		if (HasUid)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (HasRoleGoodsInfo)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RoleGoodsInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SourceData other)
	{
		if (other != null)
		{
			if (other.NIHAJMHKOBC != BKACBGFDDDA.BjlejciglaoPcpdhelpkem)
			{
				NIHAJMHKOBC = other.NIHAJMHKOBC;
			}
			switch (other.FPCDPDPHKJJCase)
			{
			case FPCDPDPHKJJOneofCase.Uid:
				Uid = other.Uid;
				break;
			case FPCDPDPHKJJOneofCase.RoleGoodsInfo:
				RoleGoodsInfo = other.RoleGoodsInfo;
				break;
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
				NIHAJMHKOBC = (BKACBGFDDDA)input.ReadEnum();
				break;
			case 88u:
				Uid = input.ReadUInt32();
				break;
			case 96u:
				fPCDPDPHKJJ_ = input.ReadEnum();
				fPCDPDPHKJJCase_ = FPCDPDPHKJJOneofCase.RoleGoodsInfo;
				break;
			}
		}
	}
}
