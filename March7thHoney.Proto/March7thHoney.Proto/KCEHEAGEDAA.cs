using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KCEHEAGEDAA : IMessage<KCEHEAGEDAA>, IMessage, IEquatable<KCEHEAGEDAA>, IDeepCloneable<KCEHEAGEDAA>, IBufferMessage
{
	private static readonly MessageParser<KCEHEAGEDAA> _parser = new MessageParser<KCEHEAGEDAA>(() => new KCEHEAGEDAA());

	private UnknownFieldSet _unknownFields;

	public const int ProgressFieldNumber = 1;

	private uint progress_;

	public const int EFDMELCFIKJFieldNumber = 2;

	private uint eFDMELCFIKJ_;

	public const int ScriptIdFieldNumber = 6;

	private uint scriptId_;

	public const int HFKBJLAMJLGFieldNumber = 8;

	private bool hFKBJLAMJLG_;

	public const int DCPKPNLKGMMFieldNumber = 9;

	private uint dCPKPNLKGMM_;

	public const int RewardFieldNumber = 11;

	private ItemList reward_;

	public const int DIOHKMPPKHAFieldNumber = 14;

	private bool dIOHKMPPKHA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KCEHEAGEDAA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KCEHEAGEDAAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EFDMELCFIKJ
	{
		get
		{
			return eFDMELCFIKJ_;
		}
		set
		{
			eFDMELCFIKJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScriptId
	{
		get
		{
			return scriptId_;
		}
		set
		{
			scriptId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HFKBJLAMJLG
	{
		get
		{
			return hFKBJLAMJLG_;
		}
		set
		{
			hFKBJLAMJLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DCPKPNLKGMM
	{
		get
		{
			return dCPKPNLKGMM_;
		}
		set
		{
			dCPKPNLKGMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList Reward
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DIOHKMPPKHA
	{
		get
		{
			return dIOHKMPPKHA_;
		}
		set
		{
			dIOHKMPPKHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCEHEAGEDAA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCEHEAGEDAA(KCEHEAGEDAA other)
		: this()
	{
		progress_ = other.progress_;
		eFDMELCFIKJ_ = other.eFDMELCFIKJ_;
		scriptId_ = other.scriptId_;
		hFKBJLAMJLG_ = other.hFKBJLAMJLG_;
		dCPKPNLKGMM_ = other.dCPKPNLKGMM_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		dIOHKMPPKHA_ = other.dIOHKMPPKHA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCEHEAGEDAA Clone()
	{
		return new KCEHEAGEDAA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KCEHEAGEDAA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KCEHEAGEDAA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Progress != other.Progress)
		{
			return false;
		}
		if (EFDMELCFIKJ != other.EFDMELCFIKJ)
		{
			return false;
		}
		if (ScriptId != other.ScriptId)
		{
			return false;
		}
		if (HFKBJLAMJLG != other.HFKBJLAMJLG)
		{
			return false;
		}
		if (DCPKPNLKGMM != other.DCPKPNLKGMM)
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (DIOHKMPPKHA != other.DIOHKMPPKHA)
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
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
		}
		if (EFDMELCFIKJ != 0)
		{
			num ^= EFDMELCFIKJ.GetHashCode();
		}
		if (ScriptId != 0)
		{
			num ^= ScriptId.GetHashCode();
		}
		if (HFKBJLAMJLG)
		{
			num ^= HFKBJLAMJLG.GetHashCode();
		}
		if (DCPKPNLKGMM != 0)
		{
			num ^= DCPKPNLKGMM.GetHashCode();
		}
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (DIOHKMPPKHA)
		{
			num ^= DIOHKMPPKHA.GetHashCode();
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
		if (Progress != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Progress);
		}
		if (EFDMELCFIKJ != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(EFDMELCFIKJ);
		}
		if (ScriptId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ScriptId);
		}
		if (HFKBJLAMJLG)
		{
			output.WriteRawTag(64);
			output.WriteBool(HFKBJLAMJLG);
		}
		if (DCPKPNLKGMM != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(DCPKPNLKGMM);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(Reward);
		}
		if (DIOHKMPPKHA)
		{
			output.WriteRawTag(112);
			output.WriteBool(DIOHKMPPKHA);
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
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		if (EFDMELCFIKJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EFDMELCFIKJ);
		}
		if (ScriptId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScriptId);
		}
		if (HFKBJLAMJLG)
		{
			num += 2;
		}
		if (DCPKPNLKGMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DCPKPNLKGMM);
		}
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (DIOHKMPPKHA)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KCEHEAGEDAA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Progress != 0)
		{
			Progress = other.Progress;
		}
		if (other.EFDMELCFIKJ != 0)
		{
			EFDMELCFIKJ = other.EFDMELCFIKJ;
		}
		if (other.ScriptId != 0)
		{
			ScriptId = other.ScriptId;
		}
		if (other.HFKBJLAMJLG)
		{
			HFKBJLAMJLG = other.HFKBJLAMJLG;
		}
		if (other.DCPKPNLKGMM != 0)
		{
			DCPKPNLKGMM = other.DCPKPNLKGMM;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
		}
		if (other.DIOHKMPPKHA)
		{
			DIOHKMPPKHA = other.DIOHKMPPKHA;
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
			case 8u:
				Progress = input.ReadUInt32();
				break;
			case 16u:
				EFDMELCFIKJ = input.ReadUInt32();
				break;
			case 48u:
				ScriptId = input.ReadUInt32();
				break;
			case 64u:
				HFKBJLAMJLG = input.ReadBool();
				break;
			case 72u:
				DCPKPNLKGMM = input.ReadUInt32();
				break;
			case 90u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 112u:
				DIOHKMPPKHA = input.ReadBool();
				break;
			}
		}
	}
}
