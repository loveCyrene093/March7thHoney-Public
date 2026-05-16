using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JPPHKCHDIJD : IMessage<JPPHKCHDIJD>, IMessage, IEquatable<JPPHKCHDIJD>, IDeepCloneable<JPPHKCHDIJD>, IBufferMessage
{
	private static readonly MessageParser<JPPHKCHDIJD> _parser = new MessageParser<JPPHKCHDIJD>(() => new JPPHKCHDIJD());

	private UnknownFieldSet _unknownFields;

	public const int GHKJBPIFBAIFieldNumber = 8;

	private uint gHKJBPIFBAI_;

	public const int AreaIdFieldNumber = 10;

	private uint areaId_;

	public const int NBACGGOFONNFieldNumber = 11;

	private uint nBACGGOFONN_;

	public const int NMLAEMLKBKJFieldNumber = 12;

	private uint nMLAEMLKBKJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JPPHKCHDIJD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JPPHKCHDIJDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GHKJBPIFBAI
	{
		get
		{
			return gHKJBPIFBAI_;
		}
		set
		{
			gHKJBPIFBAI_ = value;
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
	public uint NBACGGOFONN
	{
		get
		{
			return nBACGGOFONN_;
		}
		set
		{
			nBACGGOFONN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NMLAEMLKBKJ
	{
		get
		{
			return nMLAEMLKBKJ_;
		}
		set
		{
			nMLAEMLKBKJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JPPHKCHDIJD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JPPHKCHDIJD(JPPHKCHDIJD other)
		: this()
	{
		gHKJBPIFBAI_ = other.gHKJBPIFBAI_;
		areaId_ = other.areaId_;
		nBACGGOFONN_ = other.nBACGGOFONN_;
		nMLAEMLKBKJ_ = other.nMLAEMLKBKJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JPPHKCHDIJD Clone()
	{
		return new JPPHKCHDIJD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JPPHKCHDIJD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JPPHKCHDIJD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GHKJBPIFBAI != other.GHKJBPIFBAI)
		{
			return false;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (NBACGGOFONN != other.NBACGGOFONN)
		{
			return false;
		}
		if (NMLAEMLKBKJ != other.NMLAEMLKBKJ)
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
		if (GHKJBPIFBAI != 0)
		{
			num ^= GHKJBPIFBAI.GetHashCode();
		}
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		if (NBACGGOFONN != 0)
		{
			num ^= NBACGGOFONN.GetHashCode();
		}
		if (NMLAEMLKBKJ != 0)
		{
			num ^= NMLAEMLKBKJ.GetHashCode();
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
		if (GHKJBPIFBAI != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(GHKJBPIFBAI);
		}
		if (AreaId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(AreaId);
		}
		if (NBACGGOFONN != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(NBACGGOFONN);
		}
		if (NMLAEMLKBKJ != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(NMLAEMLKBKJ);
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
		if (GHKJBPIFBAI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GHKJBPIFBAI);
		}
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (NBACGGOFONN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NBACGGOFONN);
		}
		if (NMLAEMLKBKJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NMLAEMLKBKJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JPPHKCHDIJD other)
	{
		if (other != null)
		{
			if (other.GHKJBPIFBAI != 0)
			{
				GHKJBPIFBAI = other.GHKJBPIFBAI;
			}
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
			}
			if (other.NBACGGOFONN != 0)
			{
				NBACGGOFONN = other.NBACGGOFONN;
			}
			if (other.NMLAEMLKBKJ != 0)
			{
				NMLAEMLKBKJ = other.NMLAEMLKBKJ;
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
				GHKJBPIFBAI = input.ReadUInt32();
				break;
			case 80u:
				AreaId = input.ReadUInt32();
				break;
			case 88u:
				NBACGGOFONN = input.ReadUInt32();
				break;
			case 96u:
				NMLAEMLKBKJ = input.ReadUInt32();
				break;
			}
		}
	}
}
