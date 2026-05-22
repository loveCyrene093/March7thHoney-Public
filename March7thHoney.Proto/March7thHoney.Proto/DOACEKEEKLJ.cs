using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DOACEKEEKLJ : IMessage<DOACEKEEKLJ>, IMessage, IEquatable<DOACEKEEKLJ>, IDeepCloneable<DOACEKEEKLJ>, IBufferMessage
{
	private static readonly MessageParser<DOACEKEEKLJ> _parser = new MessageParser<DOACEKEEKLJ>(() => new DOACEKEEKLJ());

	private UnknownFieldSet _unknownFields;

	public const int DCKEEAKEOLCFieldNumber = 1;

	private uint dCKEEAKEOLC_;

	public const int NPHLEPECMAHFieldNumber = 4;

	private uint nPHLEPECMAH_;

	public const int PNFBOGKCMCEFieldNumber = 7;

	private bool pNFBOGKCMCE_;

	public const int HasPassedFieldNumber = 10;

	private bool hasPassed_;

	public const int TargetSideFieldNumber = 11;

	private uint targetSide_;

	public const int MCEKMINMJKFFieldNumber = 13;

	private uint mCEKMINMJKF_;

	public const int JDFDJACPCKCFieldNumber = 15;

	private uint jDFDJACPCKC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DOACEKEEKLJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DOACEKEEKLJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DCKEEAKEOLC
	{
		get
		{
			return dCKEEAKEOLC_;
		}
		set
		{
			dCKEEAKEOLC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NPHLEPECMAH
	{
		get
		{
			return nPHLEPECMAH_;
		}
		set
		{
			nPHLEPECMAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PNFBOGKCMCE
	{
		get
		{
			return pNFBOGKCMCE_;
		}
		set
		{
			pNFBOGKCMCE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPassed
	{
		get
		{
			return hasPassed_;
		}
		set
		{
			hasPassed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TargetSide
	{
		get
		{
			return targetSide_;
		}
		set
		{
			targetSide_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MCEKMINMJKF
	{
		get
		{
			return mCEKMINMJKF_;
		}
		set
		{
			mCEKMINMJKF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JDFDJACPCKC
	{
		get
		{
			return jDFDJACPCKC_;
		}
		set
		{
			jDFDJACPCKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOACEKEEKLJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOACEKEEKLJ(DOACEKEEKLJ other)
		: this()
	{
		dCKEEAKEOLC_ = other.dCKEEAKEOLC_;
		nPHLEPECMAH_ = other.nPHLEPECMAH_;
		pNFBOGKCMCE_ = other.pNFBOGKCMCE_;
		hasPassed_ = other.hasPassed_;
		targetSide_ = other.targetSide_;
		mCEKMINMJKF_ = other.mCEKMINMJKF_;
		jDFDJACPCKC_ = other.jDFDJACPCKC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOACEKEEKLJ Clone()
	{
		return new DOACEKEEKLJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DOACEKEEKLJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DOACEKEEKLJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DCKEEAKEOLC != other.DCKEEAKEOLC)
		{
			return false;
		}
		if (NPHLEPECMAH != other.NPHLEPECMAH)
		{
			return false;
		}
		if (PNFBOGKCMCE != other.PNFBOGKCMCE)
		{
			return false;
		}
		if (HasPassed != other.HasPassed)
		{
			return false;
		}
		if (TargetSide != other.TargetSide)
		{
			return false;
		}
		if (MCEKMINMJKF != other.MCEKMINMJKF)
		{
			return false;
		}
		if (JDFDJACPCKC != other.JDFDJACPCKC)
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
		if (DCKEEAKEOLC != 0)
		{
			num ^= DCKEEAKEOLC.GetHashCode();
		}
		if (NPHLEPECMAH != 0)
		{
			num ^= NPHLEPECMAH.GetHashCode();
		}
		if (PNFBOGKCMCE)
		{
			num ^= PNFBOGKCMCE.GetHashCode();
		}
		if (HasPassed)
		{
			num ^= HasPassed.GetHashCode();
		}
		if (TargetSide != 0)
		{
			num ^= TargetSide.GetHashCode();
		}
		if (MCEKMINMJKF != 0)
		{
			num ^= MCEKMINMJKF.GetHashCode();
		}
		if (JDFDJACPCKC != 0)
		{
			num ^= JDFDJACPCKC.GetHashCode();
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
		if (DCKEEAKEOLC != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(DCKEEAKEOLC);
		}
		if (NPHLEPECMAH != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(NPHLEPECMAH);
		}
		if (PNFBOGKCMCE)
		{
			output.WriteRawTag(56);
			output.WriteBool(PNFBOGKCMCE);
		}
		if (HasPassed)
		{
			output.WriteRawTag(80);
			output.WriteBool(HasPassed);
		}
		if (TargetSide != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(TargetSide);
		}
		if (MCEKMINMJKF != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(MCEKMINMJKF);
		}
		if (JDFDJACPCKC != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(JDFDJACPCKC);
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
		if (DCKEEAKEOLC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DCKEEAKEOLC);
		}
		if (NPHLEPECMAH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NPHLEPECMAH);
		}
		if (PNFBOGKCMCE)
		{
			num += 2;
		}
		if (HasPassed)
		{
			num += 2;
		}
		if (TargetSide != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TargetSide);
		}
		if (MCEKMINMJKF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MCEKMINMJKF);
		}
		if (JDFDJACPCKC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JDFDJACPCKC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DOACEKEEKLJ other)
	{
		if (other != null)
		{
			if (other.DCKEEAKEOLC != 0)
			{
				DCKEEAKEOLC = other.DCKEEAKEOLC;
			}
			if (other.NPHLEPECMAH != 0)
			{
				NPHLEPECMAH = other.NPHLEPECMAH;
			}
			if (other.PNFBOGKCMCE)
			{
				PNFBOGKCMCE = other.PNFBOGKCMCE;
			}
			if (other.HasPassed)
			{
				HasPassed = other.HasPassed;
			}
			if (other.TargetSide != 0)
			{
				TargetSide = other.TargetSide;
			}
			if (other.MCEKMINMJKF != 0)
			{
				MCEKMINMJKF = other.MCEKMINMJKF;
			}
			if (other.JDFDJACPCKC != 0)
			{
				JDFDJACPCKC = other.JDFDJACPCKC;
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
				DCKEEAKEOLC = input.ReadUInt32();
				break;
			case 32u:
				NPHLEPECMAH = input.ReadUInt32();
				break;
			case 56u:
				PNFBOGKCMCE = input.ReadBool();
				break;
			case 80u:
				HasPassed = input.ReadBool();
				break;
			case 88u:
				TargetSide = input.ReadUInt32();
				break;
			case 104u:
				MCEKMINMJKF = input.ReadUInt32();
				break;
			case 120u:
				JDFDJACPCKC = input.ReadUInt32();
				break;
			}
		}
	}
}
