using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AGEDPIBJPGL : IMessage<AGEDPIBJPGL>, IMessage, IEquatable<AGEDPIBJPGL>, IDeepCloneable<AGEDPIBJPGL>, IBufferMessage
{
	private static readonly MessageParser<AGEDPIBJPGL> _parser = new MessageParser<AGEDPIBJPGL>(() => new AGEDPIBJPGL());

	private UnknownFieldSet _unknownFields;

	public const int MonsterIdFieldNumber = 1;

	private uint monsterId_;

	public const int IBFBGEFLOJKFieldNumber = 2;

	private uint iBFBGEFLOJK_;

	public const int FHOLBJGOPGIFieldNumber = 3;

	private uint fHOLBJGOPGI_;

	public const int DLHLPNLIBAFFieldNumber = 4;

	private uint dLHLPNLIBAF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AGEDPIBJPGL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AGEDPIBJPGLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MonsterId
	{
		get
		{
			return monsterId_;
		}
		set
		{
			monsterId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IBFBGEFLOJK
	{
		get
		{
			return iBFBGEFLOJK_;
		}
		set
		{
			iBFBGEFLOJK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FHOLBJGOPGI
	{
		get
		{
			return fHOLBJGOPGI_;
		}
		set
		{
			fHOLBJGOPGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DLHLPNLIBAF
	{
		get
		{
			return dLHLPNLIBAF_;
		}
		set
		{
			dLHLPNLIBAF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGEDPIBJPGL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGEDPIBJPGL(AGEDPIBJPGL other)
		: this()
	{
		monsterId_ = other.monsterId_;
		iBFBGEFLOJK_ = other.iBFBGEFLOJK_;
		fHOLBJGOPGI_ = other.fHOLBJGOPGI_;
		dLHLPNLIBAF_ = other.dLHLPNLIBAF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGEDPIBJPGL Clone()
	{
		return new AGEDPIBJPGL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AGEDPIBJPGL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AGEDPIBJPGL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MonsterId != other.MonsterId)
		{
			return false;
		}
		if (IBFBGEFLOJK != other.IBFBGEFLOJK)
		{
			return false;
		}
		if (FHOLBJGOPGI != other.FHOLBJGOPGI)
		{
			return false;
		}
		if (DLHLPNLIBAF != other.DLHLPNLIBAF)
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
		if (MonsterId != 0)
		{
			num ^= MonsterId.GetHashCode();
		}
		if (IBFBGEFLOJK != 0)
		{
			num ^= IBFBGEFLOJK.GetHashCode();
		}
		if (FHOLBJGOPGI != 0)
		{
			num ^= FHOLBJGOPGI.GetHashCode();
		}
		if (DLHLPNLIBAF != 0)
		{
			num ^= DLHLPNLIBAF.GetHashCode();
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
		if (MonsterId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MonsterId);
		}
		if (IBFBGEFLOJK != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(IBFBGEFLOJK);
		}
		if (FHOLBJGOPGI != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FHOLBJGOPGI);
		}
		if (DLHLPNLIBAF != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DLHLPNLIBAF);
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
		if (MonsterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterId);
		}
		if (IBFBGEFLOJK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IBFBGEFLOJK);
		}
		if (FHOLBJGOPGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FHOLBJGOPGI);
		}
		if (DLHLPNLIBAF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DLHLPNLIBAF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AGEDPIBJPGL other)
	{
		if (other != null)
		{
			if (other.MonsterId != 0)
			{
				MonsterId = other.MonsterId;
			}
			if (other.IBFBGEFLOJK != 0)
			{
				IBFBGEFLOJK = other.IBFBGEFLOJK;
			}
			if (other.FHOLBJGOPGI != 0)
			{
				FHOLBJGOPGI = other.FHOLBJGOPGI;
			}
			if (other.DLHLPNLIBAF != 0)
			{
				DLHLPNLIBAF = other.DLHLPNLIBAF;
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
				MonsterId = input.ReadUInt32();
				break;
			case 16u:
				IBFBGEFLOJK = input.ReadUInt32();
				break;
			case 24u:
				FHOLBJGOPGI = input.ReadUInt32();
				break;
			case 32u:
				DLHLPNLIBAF = input.ReadUInt32();
				break;
			}
		}
	}
}
